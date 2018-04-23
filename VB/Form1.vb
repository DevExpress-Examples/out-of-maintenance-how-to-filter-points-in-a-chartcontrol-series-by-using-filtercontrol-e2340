Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports System.Data
Imports DevExpress.Data.Filtering.Helpers
Imports System.ComponentModel
Imports System.Collections.Generic
' ...

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Shared filterString As String

		Private Shared Function FilterData(ByVal series As Series, ByVal argument As Object, ByVal functionArguments() As String, ByVal values() As DataSourceValues) As SeriesPoint()
			Dim list As List(Of SeriesPoint) = New List(Of SeriesPoint)()
			For i As Integer = 0 To values.Length - 1
				Dim ee As New ExpressionEvaluator(TypeDescriptor.GetProperties(values(i)("")), filterString, False)
				Dim obj As Object = ee.Evaluate(values(i)(""))
				If obj Is Nothing Then
					list.Add(New SeriesPoint(argument, (CType(values(i)(""), DataRowView))("ProductID")))
				End If
				If Convert.ToBoolean(obj) Then
					list.Add(New SeriesPoint(argument, (CType(values(i)(""), DataRowView))("ProductID")))
				End If
			Next i
			Return list.ToArray()
		End Function

		Public Sub New()
			InitializeComponent()
			filterControl1.SourceControl = productsBindingSource

			chartControl1.RegisterSummaryFunction("ExtFilter", "ExtFilter", 1,New SummaryFunctionArgumentDescription() { },AddressOf FilterData)
			chartControl1.DataSource = nwindDataSet.Products
			chartControl1.Series(0).SummaryFunction = "ExtFilter()"

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
			chartControl1.RefreshData()
		End Sub

		Private Sub filterControl1_FilterChanged(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.FilterChangedEventArgs) Handles filterControl1.FilterChanged

		End Sub

		Private Sub filterControl1_FilterStringChanged(ByVal sender As Object, ByVal e As EventArgs) Handles filterControl1.FilterStringChanged
			filterString = filterControl1.FilterString
			Me.BeginInvoke(New MethodInvoker(AddressOf RefreshChart))
		End Sub
		Public Sub RefreshChart()
			   chartControl1.RefreshData()
		End Sub

	End Class
End Namespace