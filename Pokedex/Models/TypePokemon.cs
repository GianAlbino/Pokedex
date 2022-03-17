
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Pokedex.Models
{
    public partial class TypePokemon
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("damage_relations")]
        public DamageRelations DamageRelations { get; set; }

        [JsonProperty("past_damage_relations")]
        public List<PastDamageRelation> PastDamageRelations { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndex> GameIndices { get; set; }

        [JsonProperty("generation")]
        public Generation Generation { get; set; }

        [JsonProperty("move_damage_class")]
        public Generation MoveDamageClass { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("pokemon")]
        public List<Pokemon> Pokemon { get; set; }

        [JsonProperty("moves")]
        public List<Generation> Moves { get; set; }
    }

    public partial class DamageRelations
    {
        [JsonProperty("no_damage_to")]
        public List<Generation> NoDamageTo { get; set; }

        [JsonProperty("half_damage_to")]
        public List<Generation> HalfDamageTo { get; set; }

        [JsonProperty("double_damage_to")]
        public List<Generation> DoubleDamageTo { get; set; }

        [JsonProperty("no_damage_from")]
        public List<Generation> NoDamageFrom { get; set; }

        [JsonProperty("half_damage_from")]
        public List<Generation> HalfDamageFrom { get; set; }

        [JsonProperty("double_damage_from")]
        public List<Generation> DoubleDamageFrom { get; set; }
    }

    public partial class Generation
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Name
    {
        [JsonProperty("name")]
        public string NameName { get; set; }

        [JsonProperty("language")]
        public Generation Language { get; set; }
    }

    public partial class PastDamageRelation
    {
        [JsonProperty("generation")]
        public Generation Generation { get; set; }

        [JsonProperty("damage_relations")]
        public DamageRelations DamageRelations { get; set; }
    }
}
