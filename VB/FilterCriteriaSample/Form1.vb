Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Namespace FilterCriteriaSample
    Partial Public Class Form1
        Inherits XtraForm

        Private ReadOnly Property ProductSeries() As Series
            Get
                Return chartControl.Series("Products")
            End Get
        End Property
        Private Property Products() As List(Of ProductAggregate)

        Public Sub New()
            InitializeComponent()
            Using context As New NWindDataContext()
                Products = context.Products.Include("Category").Select(Function(p) New ProductAggregate With { _
                    .ProductName = p.ProductName, _
                    .CategoryName = p.Category.CategoryName, _
                    .QuantityPerUnit = p.QuantityPerUnit, _
                    .UnitPrice = p.UnitPrice.Value, _
                    .UnitsInStock = p.UnitsInStock.Value, _
                    .UnitsOnOrder = p.UnitsOnOrder.Value _
                }).ToList()
            End Using
        End Sub

        #Region "#FilterCriteria"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            filterControl.SourceControl = Products
            filterControl.FilterString = "Contains([CategoryName], 'Condiments')"

            ProductSeries.DataSource = Products
            ProductSeries.ArgumentDataMember = "ProductName"
            ProductSeries.ValueDataMembers.AddRange("UnitPrice")
            ProductSeries.FilterCriteria = filterControl.FilterCriteria
        End Sub

        Private Sub filterControl1_FilterChanged(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.FilterChangedEventArgs) Handles filterControl.FilterChanged
            ' Because of Filter Control recreates its FilterCriteria, 
            ' the criteria should be reassigned to the SeriesBase.FilterCriteria property.
            ProductSeries.FilterCriteria = filterControl.FilterCriteria
        End Sub
        #End Region ' #FilterCriteria

        Private Sub filterControl1_CreateCustomRepositoryItem(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Filtering.CreateCustomRepositoryItemEventArgs) Handles filterControl.CreateCustomRepositoryItem
            If e.Column.FieldName = "CategoryName" Then
                Dim riComboBox As New RepositoryItemComboBox()
                Using context As New NWindDataContext()
                    riComboBox.Items.AddRange(context.Categories.Select(Function(c) c.CategoryName).ToList())
                End Using
                e.RepositoryItem = riComboBox
            End If
        End Sub
    End Class
End Namespace
