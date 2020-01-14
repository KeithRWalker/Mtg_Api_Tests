
namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Set
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("mtgo_code")]
        public string MtgoCode { get; set; }

        [JsonProperty("arena_code")]
        public string ArenaCode { get; set; }

        [JsonProperty("tcgplayer_id")]
        public long TcgplayerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public Uri ScryfallUri { get; set; }

        [JsonProperty("search_uri")]
        public Uri SearchUri { get; set; }

        [JsonProperty("released_at")]
        public DateTimeOffset ReleasedAt { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("card_count")]
        public long CardCount { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("foil_only")]
        public bool FoilOnly { get; set; }

        [JsonProperty("block_code")]
        public string BlockCode { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }

        [JsonProperty("icon_svg_uri")]
        public Uri IconSvgUri { get; set; }
    }

    public partial class Set
    {
        public static Set FromJson(string json) => JsonConvert.DeserializeObject<Set>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Set self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
