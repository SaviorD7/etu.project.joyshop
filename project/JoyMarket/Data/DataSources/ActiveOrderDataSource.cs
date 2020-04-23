using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.DataSources
{
    public partial class ActiveOrderDataSource
    {
        public int OrderId { get; set; }
        public int JoySellId { get; set; }
        
        public OrderDataSource Order { get; set; }
        public JoySellDataSource JoySell { get; set; }
        public DateTime OrderTime { get; set; }
    }
}