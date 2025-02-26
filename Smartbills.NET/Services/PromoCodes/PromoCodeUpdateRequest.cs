using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.PromoCodes
{
    public record PromoCodeUpdateRequest
    {
        public bool Active { get; set; } = true;
    }
}
