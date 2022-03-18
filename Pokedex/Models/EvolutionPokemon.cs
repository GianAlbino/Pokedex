using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public partial class EvolutionPokemon
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; set; }

        [JsonProperty("baby_trigger_item", NullValueHandling = NullValueHandling.Ignore)]
        public object BabyTriggerItem { get; set; }

        [JsonProperty("chain", NullValueHandling = NullValueHandling.Ignore)]
        public Chain Chain { get; set; }
    }

    public partial class Chain
    {
        [JsonProperty("is_baby", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsBaby { get; set; }

        [JsonProperty("species", NullValueHandling = NullValueHandling.Ignore)]
        public Species Species { get; set; }

        [JsonProperty("evolution_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<EvolutionDetail> EvolutionDetails { get; set; }

        [JsonProperty("evolves_to", NullValueHandling = NullValueHandling.Ignore)]
        public List<Chain> EvolvesTo { get; set; }
    }

    public partial class EvolutionDetail
    {
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public object Item { get; set; }

        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public Species Trigger { get; set; }

        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public object Gender { get; set; }

        [JsonProperty("held_item", NullValueHandling = NullValueHandling.Ignore)]
        public object HeldItem { get; set; }

        [JsonProperty("known_move", NullValueHandling = NullValueHandling.Ignore)]
        public object KnownMove { get; set; }

        [JsonProperty("known_move_type", NullValueHandling = NullValueHandling.Ignore)]
        public object KnownMoveType { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public object Location { get; set; }

        [JsonProperty("min_level", NullValueHandling = NullValueHandling.Ignore)]
        public long MinLevel { get; set; }

        [JsonProperty("min_happiness", NullValueHandling = NullValueHandling.Ignore)]
        public object MinHappiness { get; set; }

        [JsonProperty("min_beauty", NullValueHandling = NullValueHandling.Ignore)]
        public object MinBeauty { get; set; }

        [JsonProperty("min_affection", NullValueHandling = NullValueHandling.Ignore)]
        public object MinAffection { get; set; }

        [JsonProperty("needs_overworld_rain", NullValueHandling = NullValueHandling.Ignore)]
        public bool NeedsOverworldRain { get; set; }

        [JsonProperty("party_species", NullValueHandling = NullValueHandling.Ignore)]
        public object PartySpecies { get; set; }

        [JsonProperty("party_type", NullValueHandling = NullValueHandling.Ignore)]
        public object PartyType { get; set; }

        [JsonProperty("relative_physical_stats", NullValueHandling = NullValueHandling.Ignore)]
        public object RelativePhysicalStats { get; set; }

        [JsonProperty("time_of_day", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeOfDay { get; set; }

        [JsonProperty("trade_species", NullValueHandling = NullValueHandling.Ignore)]
        public object TradeSpecies { get; set; }

        [JsonProperty("turn_upside_down", NullValueHandling = NullValueHandling.Ignore)]
        public bool TurnUpsideDown { get; set; }
    }
}
