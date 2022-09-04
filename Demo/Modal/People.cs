using Newtonsoft.Json;

namespace Demo
{
    public class People
    {
        #region Properties
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Height")]
        public int Height { get; set; }
        [JsonProperty("Mass")]
        public int Mass { get; set; }
        [JsonProperty("hair_color")]
        public string HairColor { get; set; }
        [JsonProperty("skin_color")]
        public string SkinColor { get; set; }
        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }
        [JsonProperty("birth_year")]
        public string BirthYear { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("homeworld")]
        public string HomeWorld { get; set; }
        [JsonProperty("films")]
        public string[] Films { get; set; }
        [JsonProperty("Species")]
        public string[] Species { get; set; }
        [JsonProperty("Vehicles")]
        public string[] Vehicles { get; set; }
        public string[] Starships { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
        #endregion
    }
}
