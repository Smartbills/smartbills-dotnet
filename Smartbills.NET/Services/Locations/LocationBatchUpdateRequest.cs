using Smartbills.NET.Services.Batches;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Locations
{
    public record LocationBatchUpdateRequest : BatchRequest<LocationUpdateRequest>
    {
    }
}
