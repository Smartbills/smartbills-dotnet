using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.Client.Entities
{
    public class SBBarcode
    {
        public SBBarcodeType Type { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
    }
}
