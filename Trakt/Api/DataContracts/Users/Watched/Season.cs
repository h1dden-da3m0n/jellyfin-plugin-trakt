#pragma warning disable CA1002
#pragma warning disable CA2227

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Trakt.Api.DataContracts.Users.Watched
{
    /// <summary>
    /// The trakt.tv users season watched class.
    /// </summary>
    public class Season
    {
        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        [JsonPropertyName("number")]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the episodes.
        /// </summary>
        [JsonPropertyName("episodes")]
        public List<Episode> Episodes { get; set; }
    }
}
