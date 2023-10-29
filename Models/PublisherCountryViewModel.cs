using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcGame.Models
{
    public class PublisherCountryViewModel
    {
        public List<Publisher> Publishers { get; set; }
        public SelectList Countries { get; set; }
        public string PublisherCountry { get; set; }
        public string SearchString { get; set; }
    }
}
