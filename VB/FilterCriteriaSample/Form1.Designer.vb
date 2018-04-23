Namespace FilterCriteriaSample
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
            Dim xyDiagram3 As New DevExpress.XtraCharts.XYDiagram()
            Dim series3 As New DevExpress.XtraCharts.Series()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.filterControl = New DevExpress.XtraEditors.FilterControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' chartControl
            ' 
            Me.chartControl.DataBindings = Nothing
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram3.Rotated = True
            Me.chartControl.Diagram = xyDiagram3
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Location = New System.Drawing.Point(0, 0)
            Me.chartControl.Name = "chartControl"
            series3.Name = "Products"
            series3.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
            series3.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() { series3}
            Me.chartControl.Size = New System.Drawing.Size(792, 364)
            Me.chartControl.TabIndex = 0
            ' 
            ' filterControl
            ' 
            Me.filterControl.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.filterControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.filterControl.Location = New System.Drawing.Point(0, 0)
            Me.filterControl.Name = "filterControl"
            Me.filterControl.Size = New System.Drawing.Size(792, 234)
            Me.filterControl.TabIndex = 1
            Me.filterControl.Text = "filterControl1"
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.chartControl)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.filterControl)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(792, 610)
            Me.splitContainerControl1.SplitterPosition = 364
            Me.splitContainerControl1.TabIndex = 2
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(792, 610)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(xyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl As DevExpress.XtraCharts.ChartControl
        Private WithEvents filterControl As DevExpress.XtraEditors.FilterControl
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

