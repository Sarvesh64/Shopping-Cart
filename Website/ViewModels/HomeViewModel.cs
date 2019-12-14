using Website.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> PreferredProducts { get; set; }
    }
}
