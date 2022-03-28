using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_BestOil.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> LoadEventHandler { get; set; }
        string GasolineText { get; set; } 
        string PriceText { get; set; }   
        string FoodText { get; set; }    
        string Food_priceText { get; set; } 
    }
}
