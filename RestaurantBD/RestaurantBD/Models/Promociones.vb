'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Promociones
    Public Property ID As Integer
    Public Property Descripcion As String
    Public Property estado As Boolean
    Public Property descuento As Decimal

    Public Overridable Property PromocionProducto As ICollection(Of PromocionProducto) = New HashSet(Of PromocionProducto)

End Class
