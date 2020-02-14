using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDeliveryUI.Models
{
    public class Package
    {
        public int NumberTranking { get; set; }
        public string NamePackage { get; set; }
        public string Description { get; set; }
        public int PountsPackage { get; set; }
        public string StatePackage { get; set; }
        public string LocationPackage { get; set; }
    }
}
