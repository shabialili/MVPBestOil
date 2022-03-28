using MVP_BestOil.Models;
using MVP_BestOil.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_BestOil.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;    

        public MainPresenter (IMainView view)
        {
            mainView = view;

            mainView.LoadEventHandler += LoadButtonClicked;
           
        }

        private void LoadButtonClicked(object sender,EventArgs e)
        {
            var oil = new Oil
            {
                Gasoline = mainView.GasolineText,
                Price = double.Parse(mainView.PriceText),
                Food = mainView.FoodText,   
                Food_price = double.Parse(mainView.FoodText)

            };
        }
    }
}
