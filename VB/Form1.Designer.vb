Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.productsTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.nwindDataSet = New WindowsApplication1.nwindDataSet()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.filterControl1 = New DevExpress.XtraEditors.FilterControl()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.DataAdapter = Me.productsTableAdapter
            Me.chartControl1.DataSource = Me.nwindDataSet.Products
            XyDiagram1.AxisX.Label.Angle = 45
            XyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisX.WholeRange.AutoSideMargins = True
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.WholeRange.AutoSideMargins = True
            Me.chartControl1.Diagram = XyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.RefreshDataOnRepaint = False
            Series1.ArgumentDataMember = "ProductName"
            Series1.Name = "Series 2"
            Series1.SummaryFunction = "COUNT()"
            Series1.View = LineSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
            Me.chartControl1.SeriesTemplate.View = LineSeriesView2
            Me.chartControl1.Size = New System.Drawing.Size(763, 364)
            Me.chartControl1.TabIndex = 0
            '
            'productsTableAdapter
            '
            Me.productsTableAdapter.ClearBeforeFill = True
            '
            'nwindDataSet
            '
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'productsBindingSource
            '
            Me.productsBindingSource.DataMember = "Products"
            Me.productsBindingSource.DataSource = Me.nwindDataSet
            '
            'filterControl1
            '
            Me.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.filterControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.filterControl1.Location = New System.Drawing.Point(0, 364)
            Me.filterControl1.Name = "filterControl1"
            Me.filterControl1.Size = New System.Drawing.Size(763, 203)
            Me.filterControl1.TabIndex = 1
            Me.filterControl1.Text = "filterControl1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(763, 567)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.filterControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private productsTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter
		Private nwindDataSet As nwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private WithEvents filterControl1 As DevExpress.XtraEditors.FilterControl
	End Class
End Namespace

