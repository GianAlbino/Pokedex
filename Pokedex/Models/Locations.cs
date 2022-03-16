using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pokedex.Models
{

    public partial class Locations
    {
        [JsonProperty("location_area")]
        public LocationArea LocationArea { get; set; }

        [JsonProperty("version_details")]
        public List<VersionDetail> VersionDetails { get; set; }
    }

    public partial class LocationArea
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class VersionDetail
    {
        [JsonProperty("max_chance")]
        public long MaxChance { get; set; }

        [JsonProperty("encounter_details")]
        public List<EncounterDetail> EncounterDetails { get; set; }
    }

    public partial class EncounterDetail
    {
        [JsonProperty("min_level")]
        public long MinLevel { get; set; }

        [JsonProperty("max_level")]
        public long MaxLevel { get; set; }

        [JsonProperty("condition_values")]
        public List<LocationArea> ConditionValues { get; set; }

        [JsonProperty("chance")]
        public long Chance { get; set; }

        [JsonProperty("method")]
        public LocationArea Method { get; set; }
    }
}

