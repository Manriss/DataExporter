Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DATAEXPORTER.MGD

Public Class DistintItemComparer
    Inherits EqualityComparer(Of Propiedades)

    Public Overrides Function Equals(x As Propiedades, y As Propiedades) As Boolean
        If (x.Categoria = y.Categoria) And (x.Propiedad = y.Propiedad) Then

            Return True
        Else
            Return False

        End If

    End Function

    Public Overrides Function GetHashCode(obj As Propiedades) As Integer
        If Object.ReferenceEquals(obj, vbNull) Then
            Return 0
        End If
        Dim hashCName As Integer = obj.Categoria.GetHashCode
        Dim hashPName As Integer = obj.Propiedad.GetHashCode
        Return hashPName Xor hashCName


    End Function
End Class
