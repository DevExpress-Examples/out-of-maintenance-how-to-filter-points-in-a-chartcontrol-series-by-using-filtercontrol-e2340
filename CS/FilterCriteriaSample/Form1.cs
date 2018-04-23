using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace FilterCriteriaSample {
    public partial class Form1 : XtraForm {
        Series ProductSeries { get { return chartControl.Series["Products"]; } }
        List<ProductAggregate> Products { get; set; }

        public Form1() {
            InitializeComponent();
            using(NWindDataContext context = new NWindDataContext()) {
                Products = context.Products
                   .Include("Category")
                   .Select(p => new ProductAggregate {
                       ProductName = p.ProductName,
                       CategoryName = p.Category.CategoryName,
                       QuantityPerUnit = p.QuantityPerUnit,
                       UnitPrice = p.UnitPrice.Value,
                       UnitsInStock = p.UnitsInStock.Value,
                       UnitsOnOrder = p.UnitsOnOrder.Value
                   })
                   .ToList();
            }
        }

        #region #FilterCriteria
        private void Form1_Load(object sender, EventArgs e) {
            filterControl.SourceControl = Products;
            filterControl.FilterString = "Contains([CategoryName], 'Condiments')";

            ProductSeries.DataSource = Products;
            ProductSeries.ArgumentDataMember = "ProductName";
            ProductSeries.ValueDataMembers.AddRange("UnitPrice");
            ProductSeries.FilterCriteria = filterControl.FilterCriteria;
        }

        private void filterControl1_FilterChanged(object sender, DevExpress.XtraEditors.FilterChangedEventArgs e) {
            // Because of Filter Control recreates its FilterCriteria, 
            // the criteria should be reassigned to the SeriesBase.FilterCriteria property.
            ProductSeries.FilterCriteria = filterControl.FilterCriteria;
        }
        #endregion #FilterCriteria

        private void filterControl1_CreateCustomRepositoryItem(object sender, DevExpress.XtraEditors.Filtering.CreateCustomRepositoryItemEventArgs e) {
            if (e.Column.FieldName == "CategoryName") {
                RepositoryItemComboBox riComboBox = new RepositoryItemComboBox();
                using(NWindDataContext context = new NWindDataContext()) {
                    riComboBox.Items.AddRange(
                        context.Categories
                        .Select(c => c.CategoryName)
                        .ToList()
                    );
                }
                e.RepositoryItem = riComboBox;
            }
        }
    }
}
