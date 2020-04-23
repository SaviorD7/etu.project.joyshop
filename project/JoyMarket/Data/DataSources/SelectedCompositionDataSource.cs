using System.ComponentModel.DataAnnotations;

namespace Data.DataSources
{
    public partial class SelectedCompositionDataSource
    {
        public int JoySellId { get; set; }
        public int CompositionId { get; set; }
        
        public JoySellDataSource JoySell { get; set; }
        public CompositionDataSource Composition { get; set; }
    }
}