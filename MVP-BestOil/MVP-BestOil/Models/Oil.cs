using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_BestOil.Models
{
    public class Oil
    {
        public int Id { get; set; } 
        public string Gasoline { get; set; }
        public double Price { get; set; }
        public string Food { get; set; }
        public double Food_price { get; set; }

        public override string ToString()
        {
            return $"{Gasoline} {Price} {Food} {Food_price}";
        }

    }
}
