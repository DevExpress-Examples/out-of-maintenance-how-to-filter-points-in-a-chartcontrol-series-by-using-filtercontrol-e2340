Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace FilterCriteriaSample
    Friend Class ProductAggregate
        Public Property ProductName() As String
        Public Property CategoryName() As String

        <StringLength(20)> _
        Public Property QuantityPerUnit() As String

        Public Property UnitPrice() As Decimal

        Public Property UnitsInStock() As Short

        Public Property UnitsOnOrder() As Short

        Public ReadOnly Property OnOrderIncome() As Decimal
            Get
                Return UnitsOnOrder * UnitPrice
            End Get
        End Property
    End Class
End Namespace
