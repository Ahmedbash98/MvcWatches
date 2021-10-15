using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcWatches.Models
{
    public class WatchesModelViewModel
    {
        public List<Watch> Watches { get; set; }
        public SelectList Model { get; set; }
        public string WatchModel { get; set; }
        public string SearchString { get; set; }
    }
}
