using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webProje.Models;

namespace webProje.ViewModels
{
    
    public class IndexViewModel
    {
        public IEnumerable<Haber> Haberler { get; set; }
        public Uyeler uye { get; set; }
    }
}