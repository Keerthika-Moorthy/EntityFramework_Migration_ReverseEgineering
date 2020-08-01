using System;
using System.Collections.Generic;
using System.Text;

namespace NinjaApp.Domain
{
   public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Ninja Ninja { get; set; }
        public int NinjaId { get; set; }

    }
}
