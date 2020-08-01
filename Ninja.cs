using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NinjaApp.Domain
{
   public class Ninja
    {
        public Ninja()
        {
            Quotes = new List<Quote>();
        }
        public int  Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public Clan Clan { get; set; }

    }
}
