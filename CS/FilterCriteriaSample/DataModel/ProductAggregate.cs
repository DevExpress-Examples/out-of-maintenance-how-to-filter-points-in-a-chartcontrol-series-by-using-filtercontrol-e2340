using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterCriteriaSample {
    class ProductAggregate {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }

        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public short UnitsInStock { get; set; }

        public short UnitsOnOrder { get; set; }

        public decimal OnOrderIncome {
            get {
                return UnitsOnOrder * UnitPrice;
            }
        }
    }
}
