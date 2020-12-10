using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakelYemekhaneWebService
{
    public class GunlukMenu
    {
        public DateTime tarih;
        public string yemek1, yemek2, yemek3, yemek4, yemek5;

        public GunlukMenu(DateTime tarih)
        {
            this.tarih = tarih;
        }           
    }
}