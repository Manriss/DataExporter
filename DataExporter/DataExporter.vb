Option Explicit On
#Region "DockingPanel"
Imports System.Windows.Forms
Imports Autodesk.Navisworks.Api.Plugins
Imports Autodesk.Navisworks.Api
Imports Autodesk.Navisworks.Api.DocumentParts
Imports System.Diagnostics
Imports System.IO
Imports System.Globalization

<PluginAttribute(
                "Data Exporter",
                 "MGD",
                 ToolTip:="Modulo para exportar datos desarrollado por Manrique Gómez",
                ExtendedToolTip:="extended",
                 DisplayName:="DATA EXPORTER (v00.05-Beta) Navisworks 2019 by MGD")>
<DockPanePlugin(
1000, 300, AutoScroll:=True, FixedSize:=False, MinimumHeight:=300, MinimumWidth:=800)>
Public Class DataExporter
    Inherits DockPanePlugin

    Public Overrides Function CreateControlPane() As Control
        Dim formulario As New listaDatos()
        formulario.Dock = DockStyle.Fill
        formulario.Text = "DATA EXPORTER"
        formulario.CreateControl()
        Return formulario
    End Function
    Public Overrides Sub DestroyControlPane(pane As Control)
        pane.Dispose()
    End Sub



End Class
#End Region
