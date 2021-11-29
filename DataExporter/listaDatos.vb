Imports System.Windows.Forms
Imports Autodesk.Navisworks.Api
Imports BrightIdeasSoftware
Imports System.IO
Imports System.Resources
Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel
Imports System.Text

Public Class listaDatos
    Inherits UserControl



    Public Sub listaDatos()

        InitializeComponent()

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try
            tablaDatos.Reset()
            fdlObjetosExportar.ResetColumnFiltering()
            Dim items As New ModelItemCollection
            Dim seleccion As New Selection
            Dim listaPropiedadesTemporal As New List(Of Propiedades)
            fdlObjetosExportar.Clear()
            ' items = Autodesk.Navisworks.Api.Application.ActiveDocument.CurrentSelection.SelectedItems
            If items.Count > 0 Then
                items.Clear()
            End If
            items.CopyFrom(doc.CurrentSelection.SelectedItems)
            seleccion.CopyFrom(doc.CurrentSelection.ToSelection)

            ' items.Invert(doc)
            Debug.WriteLine(items.Count)
            If items.Count > 5 Then
                MsgBox("Esta funcionalidad esta limitada a 5 elementos")
                Exit Sub
            End If
            For Each item As ModelItem In items
                Dim cat As PropertyCategory
                For Each cat In item.PropertyCategories
                    For Each dp As DataProperty In cat.Properties
                        Dim newProp As New Propiedades
                        newProp.Categoria = cat.DisplayName
                        newProp.Propiedad = dp.DisplayName
                        listaPropiedadesTemporal.Add(newProp)
                    Next
                Next
                ' Exit For 'prueba primer item
            Next
            Dim ncomp As New DistintItemComparer
            Debug.WriteLine(listaPropiedadesTemporal.Count)
            listaPropiedades = New List(Of Propiedades)
            listaPropiedades = listaPropiedadesTemporal.Distinct(ncomp).ToList
            Dim selector As New frmSelectorPropiedades
            selector.ShowDialog()
            If listaPropiedadesExportar.Count > 0 Then
                infolabel.Text = "Propiedades seleccionadas, seleccione los elementos a exportar"
                fdlObjetosExportar.EmptyListMsg = "Seleccione los elementos que quiere exportar"
                propsUpdated = propsUpdated + 1

            Else
                fdlObjetosExportar.EmptyListMsg = "Sin Datos"
                infolabel.Text = "Seleccione hasta 5 elementos para elegir las propiedades a exportar, luego seleccione los elementos a exportar"
            End If
        Catch ex As Exception
            MsgBox("Error obteniendo propiedades: " & vbCr & ex.ToString)
        End Try
    End Sub
    Private Sub getProperties(ByVal items As ModelItemCollection)
        tablaDatos = New DataTable


        Dim contador As Integer = 0
        Try
            fdlObjetosExportar.DataSource = Nothing
            fdlObjetosExportar.ClearObjects()

            For Each col As Propiedades In listaPropiedadesExportar
                tablaDatos.Columns.Add(New DataColumn(col.Propiedad & " (" & col.Categoria & ")"))
            Next




            Me.Cursor = Cursors.WaitCursor
            'Obtener datos del modelo...
            Dim numItems As Integer = items.Count
            Dim salto10 As Integer
            If numItems < 10 Then
                salto10 = 1
            Else
                salto10 = numItems / 10
            End If
            infolabel.Text = "Procesando " & contador & " de " & numItems
            For Each item In items

                Dim r As DataRow = tablaDatos.NewRow
                For Each obj As Propiedades In listaPropiedadesExportar

                    r(obj.Propiedad & " (" & obj.Categoria & ")") = tiposDatoNavis(item.PropertyCategories.FindPropertyByDisplayName(obj.Categoria, obj.Propiedad))

                Next
                tablaDatos.Rows.Add(r)
                contador = contador + 1

                If (contador Mod salto10) = 0 Then
                    tsbProgress.Value = tsbProgress.Value + 10
                    infolabel.Text = "Procesando " & contador & " de " & numItems
                End If
            Next
            '****
            'If fdlObjetosExportar.DataSource Is Nothing Then
            '    fdlObjetosExportar.DataSource = tablaDatos
            'Else
            '
            fdlObjetosExportar.Reset()
            fdlObjetosExportar.DataSource = tablaDatos
            fdlObjetosExportar.BuildList()
            'fdlObjetosExportar.RebuildColumns()



            'fdlObjetosExportar.Refresh()
            ' End If

            fdlObjetosExportar.AutoResizeColumns()
            fdlObjetosExportar.Refresh()
            Me.Cursor = Cursors.Default
            If tablaDatos.Rows.Count > 0 Then
                btnExportSeleccion.Enabled = True
                infolabel.Text = "Datos obtenidos, " & contador & " elementos obtenidos, listo para exportar"
                tsbProgress.Value = 0
            End If
        Catch ex As Exception
            MsgBox("Error obteniendo propiedades: " & vbCr & ex.ToString)
        End Try
    End Sub


    Private Sub exportarCSV()
        Try
            Dim csv As String = ""
            Dim exporter As New OLVExporter(fdlObjetosExportar, fdlObjetosExportar.FilteredObjects)
            csv = exporter.ExportTo(OLVExporter.ExportFormat.TabSeparated)
            csv = csv.Replace(vbTab, ";")
            Dim sfl As New SaveFileDialog
            sfl.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            sfl.RestoreDirectory = True
            sfl.FileName = "Exportado.csv"
            sfl.Filter = "csv files (*.csv|*.csv"
            If sfl.ShowDialog = DialogResult.OK Then

                Using sw As New StreamWriter(sfl.FileName, False, Encoding.UTF8)

                    sw.Write(csv)

                End Using
            End If
            infolabel.Text = "Datos exportados"
            MsgBox("Exportacion finalizada")
        Catch ex As Exception
            MsgBox("Error en el modulo de exportación: " & vbCr & ex.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Exporta los elementos seleccionados
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExportSeleccion_Click(sender As Object, e As EventArgs) Handles btnExportSeleccion.Click
        Try
            If fdlObjetosExportar.GetItemCount > 0 Then
                exportarCSV()
            End If

        Catch ex As Exception
            MsgBox("Error al exportar: " & vbCr & ex.ToString)
        End Try

    End Sub
    ''' <summary>
    ''' Utilido el evento de seleccion para activar el boton de seleccionar propiedades
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub listaDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            infolabel.Text = "Seleccione hasta 5 elementos para elegir las propiedades a exportar, luego seleccione los elementos a exportar"
            AddHandler doc.CurrentSelection.Changed, AddressOf seleccionActualizada
        Catch ex As Exception
            MsgBox("Error " & ex.ToString)
        End Try


    End Sub
    ''' <summary>
    ''' Solo podre utilizar la seleccion si tengo menos de 6 elementos
    ''' </summary>
    Private Sub seleccionActualizada()
        Try
            If Not doc.CurrentSelection.IsEmpty And doc.CurrentSelection.SelectedItems.Count < 6 Then
                btnSeleccionar.Enabled = True
            Else
                btnSeleccionar.Enabled = False

            End If
            If Not doc.CurrentSelection.IsEmpty And listaPropiedadesExportar.Count > 0 Then
                btnGetData.Enabled = True
            Else
                btnGetData.Enabled = False
            End If

        Catch ex As Exception
            MsgBox("Error al actulizar seleccion: " & vbCr & ex.ToString)
        End Try

    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        Try
            If Not doc.CurrentSelection.IsEmpty Then
                Dim seleccion As New Selection
                seleccion = doc.CurrentSelection
                getProperties(seleccion.GetSelectedItems)

            End If

        Catch ex As Exception
            MsgBox("Error al obtener datos de la seleccion: " & vbCr & ex.ToString)
        End Try
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try

            If txtTextoFiltro.Text <> "" Then
                Dim valor As String = txtTextoFiltro.Text
                Dim arr() As String = valor.Split(";")
                Dim filtro As TextMatchFilter

                filtro = TextMatchFilter.Contains(fdlObjetosExportar, arr)

                fdlObjetosExportar.ModelFilter = filtro
            Else

            End If



        Catch ex As Exception
            MsgBox("Error al filtrar: " & ex.ToString)
        End Try





    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Try
            fdlObjetosExportar.ModelFilter = Nothing
            txtTextoFiltro.Clear()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tssHelp_Click(sender As Object, e As EventArgs) Handles tssHelp.Click
        If System.Threading.Thread.CurrentThread.CurrentCulture.Name = "en" Then
            MsgBox(My.Resources.Warning, MsgBoxStyle.Information, "WARNING")
        Else
            MsgBox(My.Resources.Alerta, MsgBoxStyle.Information, "ATENCION")
        End If




    End Sub

    Private Sub tssHelp_MouseEnter(sender As Object, e As EventArgs) Handles tssHelp.MouseEnter
        Try
            Me.Cursor = Cursors.Help
        Catch ex As Exception
            MsgBox("Error cursor 1" & ex.ToString)
        End Try

    End Sub

    Private Sub tssHelp_MouseLeave(sender As Object, e As EventArgs) Handles tssHelp.MouseLeave
        Try
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Error cursor 2" & ex.ToString)
        End Try

    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub
End Class
