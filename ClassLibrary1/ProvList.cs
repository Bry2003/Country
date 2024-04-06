using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvinceBL
{
    public class ProvList
    {
        public string name;
        List<TProvince> TProvinces = new List<TProvince> { };

       public void DisplayProvinceInfo( TProvince province)
        {
            Console.WriteLine("TITLE:"+ province.title);
            Console.WriteLine("LOCATION:"+ province.location);
            Console.WriteLine("DESCRIPTION:"+ province.description);
        }
    }
}