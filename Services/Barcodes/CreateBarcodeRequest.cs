using Smartbills.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public class CreateBarcodeRequest: BaseRequest
    {
        public SBBarcodeType Type { get; set; }
        public string Text { get; set; }
    }
}
