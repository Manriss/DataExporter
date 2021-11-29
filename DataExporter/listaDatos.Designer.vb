<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listaDatos
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listaDatos))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.fdlObjetosExportar = New BrightIdeasSoftware.FastDataListView()
        Me.sstInfo = New System.Windows.Forms.StatusStrip()
        Me.tsbProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.infolabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtTextoFiltro = New System.Windows.Forms.TextBox()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.btnExportSeleccion = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.fdlObjetosExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sstInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.fdlObjetosExportar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.sstInfo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnGetData)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnExportSeleccion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSeleccionar)
        '
        'fdlObjetosExportar
        '
        Me.fdlObjetosExportar.AllowColumnReorder = True
        Me.fdlObjetosExportar.CellEditUseWholeCell = False
        Me.fdlObjetosExportar.DataSource = Nothing
        resources.ApplyResources(Me.fdlObjetosExportar, "fdlObjetosExportar")
        Me.fdlObjetosExportar.EmptyListMsgFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fdlObjetosExportar.FullRowSelect = True
        Me.fdlObjetosExportar.GridLines = True
        Me.fdlObjetosExportar.Name = "fdlObjetosExportar"
        Me.fdlObjetosExportar.ShowFilterMenuOnRightClick = False
        Me.fdlObjetosExportar.ShowGroups = False
        Me.fdlObjetosExportar.UseCompatibleStateImageBehavior = False
        Me.fdlObjetosExportar.UseFilterIndicator = True
        Me.fdlObjetosExportar.UseFiltering = True
        Me.fdlObjetosExportar.View = System.Windows.Forms.View.Details
        Me.fdlObjetosExportar.VirtualMode = True
        '
        'sstInfo
        '
        Me.sstInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbProgress, Me.infolabel, Me.tssHelp})
        resources.ApplyResources(Me.sstInfo, "sstInfo")
        Me.sstInfo.Name = "sstInfo"
        '
        'tsbProgress
        '
        Me.tsbProgress.Name = "tsbProgress"
        resources.ApplyResources(Me.tsbProgress, "tsbProgress")
        '
        'infolabel
        '
        Me.infolabel.Name = "infolabel"
        resources.ApplyResources(Me.infolabel, "infolabel")
        '
        'tssHelp
        '
        Me.tssHelp.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        resources.ApplyResources(Me.tssHelp, "tssHelp")
        Me.tssHelp.Margin = New System.Windows.Forms.Padding(300, 3, 0, 2)
        Me.tssHelp.Name = "tssHelp"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.txtTextoFiltro)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btnReset
        '
        resources.ApplyResources(Me.btnReset, "btnReset")
        Me.btnReset.Name = "btnReset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnFiltrar
        '
        resources.ApplyResources(Me.btnFiltrar, "btnFiltrar")
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.ToolTip1.SetToolTip(Me.btnFiltrar, resources.GetString("btnFiltrar.ToolTip"))
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'txtTextoFiltro
        '
        resources.ApplyResources(Me.txtTextoFiltro, "txtTextoFiltro")
        Me.txtTextoFiltro.Name = "txtTextoFiltro"
        Me.ToolTip1.SetToolTip(Me.txtTextoFiltro, resources.GetString("txtTextoFiltro.ToolTip"))
        '
        'btnGetData
        '
        resources.ApplyResources(Me.btnGetData, "btnGetData")
        Me.btnGetData.Name = "btnGetData"
        Me.ToolTip1.SetToolTip(Me.btnGetData, resources.GetString("btnGetData.ToolTip"))
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnExportSeleccion
        '
        resources.ApplyResources(Me.btnExportSeleccion, "btnExportSeleccion")
        Me.btnExportSeleccion.Name = "btnExportSeleccion"
        Me.btnExportSeleccion.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        resources.ApplyResources(Me.btnSeleccionar, "btnSeleccionar")
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.ToolTip1.SetToolTip(Me.btnSeleccionar, resources.GetString("btnSeleccionar.ToolTip"))
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'listaDatos
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "listaDatos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.fdlObjetosExportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sstInfo.ResumeLayout(False)
        Me.sstInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents sstInfo As Windows.Forms.StatusStrip
    Friend WithEvents btnSeleccionar As Windows.Forms.Button
    Friend WithEvents fdlObjetosExportar As BrightIdeasSoftware.FastDataListView
    Friend WithEvents btnExportSeleccion As Windows.Forms.Button
    Friend WithEvents btnGetData As Windows.Forms.Button
    Friend WithEvents infolabel As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btnFiltrar As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents txtTextoFiltro As Windows.Forms.TextBox
    Friend WithEvents btnReset As Windows.Forms.Button
    Friend WithEvents tsbProgress As Windows.Forms.ToolStripProgressBar
    Friend WithEvents tssHelp As Windows.Forms.ToolStripStatusLabel
End Class
