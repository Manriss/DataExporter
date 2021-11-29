<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSelectorPropiedades
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectorPropiedades))
        Me.olvPropiedades = New BrightIdeasSoftware.ObjectListView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.olvPropiedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'olvPropiedades
        '
        resources.ApplyResources(Me.olvPropiedades, "olvPropiedades")
        Me.olvPropiedades.CellEditUseWholeCell = False
        Me.olvPropiedades.Cursor = System.Windows.Forms.Cursors.Default
        Me.olvPropiedades.Name = "olvPropiedades"
        Me.olvPropiedades.OverlayText.Text = resources.GetString("resource.Text")
        Me.olvPropiedades.UseCompatibleStateImageBehavior = False
        Me.olvPropiedades.View = System.Windows.Forms.View.Details
        '
        'btnAceptar
        '
        resources.ApplyResources(Me.btnAceptar, "btnAceptar")
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmSelectorPropiedades
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.olvPropiedades)
        Me.Name = "frmSelectorPropiedades"
        CType(Me.olvPropiedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents olvPropiedades As BrightIdeasSoftware.ObjectListView
    Friend WithEvents btnAceptar As Windows.Forms.Button
End Class
