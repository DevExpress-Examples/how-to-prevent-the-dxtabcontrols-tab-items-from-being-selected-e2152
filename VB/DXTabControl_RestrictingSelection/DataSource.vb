Imports System
Imports System.Collections.Generic

Namespace DXExample.DemoData
    Public Enum InvoiceStatus
        Ordered
        Payed
        Shipped
        Delivered
        Invalidated
    End Enum
    Public Class Invoice
        Public Property ID() As Integer
        Public Property ProductName() As String
        Public Property Price() As Double
        Public Property OrderDate() As Date
        Public Property Discount() As Double
        Public Property IsUrgent() As Boolean
        Public Property Status() As InvoiceStatus
        Public Shared Function GetData() As List(Of Invoice)
            Dim data As New List(Of Invoice)()

            data.Add(New Invoice() With {.ID = 0, .ProductName = "Tofu", .IsUrgent = False, .Price = 235.54, .Discount = 9.4, .Status = InvoiceStatus.Invalidated, .OrderDate = New Date(2009, 3, 12)})
            data.Add(New Invoice() With {.ID = 1, .ProductName = "Ravioli Angelo", .IsUrgent = True, .Price = 178.45, .Discount = 6.1, .Status = InvoiceStatus.Delivered, .OrderDate = New Date(2009, 2, 9)})
            data.Add(New Invoice() With {.ID = 2, .ProductName = "Geitost", .IsUrgent = False, .Price = 89.98, .Discount = 5.4, .Status = InvoiceStatus.Payed, .OrderDate = New Date(2009, 4, 1)})
            data.Add(New Invoice() With {.ID = 3, .ProductName = "Chang", .IsUrgent = True, .Price = 189.33, .Discount = 18.2, .Status = InvoiceStatus.Shipped, .OrderDate = New Date(2009, 5, 23)})
            data.Add(New Invoice() With {.ID = 4, .ProductName = "Inlagd Sill", .IsUrgent = False, .Price = 509.10, .Discount = 22.2, .Status = InvoiceStatus.Ordered, .OrderDate = New Date(2009, 6, 30)})
            data.Add(New Invoice() With {.ID = 5, .ProductName = "Alice Mutton", .IsUrgent = True, .Price = 791.18, .Discount = 24.4, .Status = InvoiceStatus.Invalidated, .OrderDate = New Date(2009, 5, 7)})

            Return data
        End Function
    End Class
End Namespace
