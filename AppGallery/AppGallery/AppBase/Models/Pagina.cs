using System;
using System.Collections.Generic;
using System.Text;

namespace AppGallery.AppBase.Models
{
    public class Pagina
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Type PageFile { get; set; }
        public bool IsNavigation { get; set; }
    }
}
