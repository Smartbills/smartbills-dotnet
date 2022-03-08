using System;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    /// <summary>
    /// Class representing the GPS coordinates of an <seealso cref="SBAddress">address</seealso>.
    /// </summary>
    public class SBLocation : SmartbillsEntityWithId
    {
        public SBLocation() { }
        /// <summary>
        /// <value>
        /// The longitude of the location.
        /// </value>
        /// </summary>
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; } = 0;

        /// <summary>
        /// <value>
        /// The latitude of the location.
        /// </value>
        /// </summary>
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; } = 0;
        public DateTimeOffset? ExpiresAt { get; set; }

    }
}