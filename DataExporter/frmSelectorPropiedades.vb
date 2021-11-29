Imports BrightIdeasSoftware
Imports BrightIdeasSoftware.Design
Imports System.ComponentModel
Imports System.Globalization
Imports System.Windows.Forms
Public Class frmSelectorPropiedades
    Private Sub frmSelectorPropiedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each c As Control In Me.Controls
                Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmSelectorPropiedades))
                resources.ApplyResources(c, c.Name, New CultureInfo("en"))
            Next c
            Dim colProp As New OLVColumn("Propiedad", "Propiedad")
            colProp.GroupKeyGetter = Function(o As Propiedades)
                                         Return o.Categoria
                                     End Function

            colProp.Width = 100
            colProp.HeaderCheckBox = True
            colProp.FillsFreeSpace = True
            olvPropiedades.Columns.Add(colProp)
            olvPropiedades.SetObjects(listaPropiedades)
            olvPropiedades.CheckBoxes = True
            olvPropiedades.ShowGroups = True
            olvPropiedades.Refresh()
        Catch ex As Exception
            MsgBox("Error " & ex.ToString)
        End Try

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            listaPropiedadesExportar = New ArrayList
            listaPropiedadesExportar = olvPropiedades.CheckedObjects
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al obtener listado depropiedades: " & vbCr & ex.ToString)
        End Try

    End Sub
End Class