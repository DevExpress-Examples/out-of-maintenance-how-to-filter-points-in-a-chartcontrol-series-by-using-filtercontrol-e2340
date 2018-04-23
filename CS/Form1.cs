using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using System.Data;
using DevExpress.Data.Filtering.Helpers;
using System.ComponentModel;
using System.Collections.Generic;
// ...

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        static string filterString;

        private static SeriesPoint[] FilterData(Series series, object argument, string[] functionArguments, DataSourceValues[] values)
        {
            List<SeriesPoint> list = new List<SeriesPoint>();
            for (int i = 0; i < values.Length; i++) {
                ExpressionEvaluator ee = new ExpressionEvaluator(TypeDescriptor.GetProperties(values[i][""]), filterString, false);
                object obj = ee.Evaluate(values[i][""]);
                if (obj == null)
                    list.Add(new SeriesPoint(argument, ((DataRowView)values[i][""])["ProductID"]));
                if (Convert.ToBoolean(obj))
                    list.Add(new SeriesPoint(argument, ((DataRowView)values[i][""])["ProductID"]));
            }
            return list.ToArray();
        }

        public Form1() {
            InitializeComponent();
            filterControl1.SourceControl = productsBindingSource;

            chartControl1.RegisterSummaryFunction("ExtFilter", "ExtFilter", 1,new SummaryFunctionArgumentDescription[] { },FilterData);
            chartControl1.DataSource = nwindDataSet.Products;
            chartControl1.Series[0].SummaryFunction = "ExtFilter()";
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            chartControl1.RefreshData();
        }

        private void filterControl1_FilterChanged(object sender, DevExpress.XtraEditors.FilterChangedEventArgs e)
        {

        }

        private void filterControl1_FilterStringChanged(object sender, EventArgs e)
        {
            filterString = filterControl1.FilterString;
            this.BeginInvoke(new MethodInvoker(RefreshChart));
        }
        public void RefreshChart(){
               chartControl1.RefreshData();
        }
        
    }
}