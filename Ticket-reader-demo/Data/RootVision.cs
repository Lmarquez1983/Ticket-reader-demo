namespace Ticket_reader_demo.Data
{
    public class RootVision
    {
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Caption
    {
        public string text { get; set; }
        public double confidence { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public double score { get; set; }
    }

    public class Color
    {
        public string dominantColorForeground { get; set; }
        public string dominantColorBackground { get; set; }
        public List<string> dominantColors { get; set; }
        public string accentColor { get; set; }
        public bool isBwImg { get; set; }
        public bool isBWImg { get; set; }
    }

    public class Description
    {
        public List<string> tags { get; set; }
        public List<Caption> captions { get; set; }
    }

    public class Metadata
    {
        public int height { get; set; }
        public int width { get; set; }
        public string format { get; set; }
    }

    public class Root
    {
        public List<Category> categories { get; set; }
        public Color color { get; set; }
        public Description description { get; set; }
        public string requestId { get; set; }
        public Metadata metadata { get; set; }
        public string modelVersion { get; set; }
    }



}
