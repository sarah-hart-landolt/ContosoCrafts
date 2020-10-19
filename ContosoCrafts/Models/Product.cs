using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }

        // mapping "img" to image
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        //most objects in .NET have a ToString 
        //taking this object information and converting in back into text that'll be in the json file
        // made it a single statement (linq syntax) one one line with rocketship
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
