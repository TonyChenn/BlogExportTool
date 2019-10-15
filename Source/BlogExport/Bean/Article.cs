public class Article
{
    public int Index { get; set; }
    public string Id { get; set; }
    public string Title { get; set; }
    public string Pubulisher { get; set; }
    public string Time { get; set; }
    public System.Collections.Generic.List<string> tags { get; set; }
    public string Content { get; set; }

    public string Link { get; set; }
}
