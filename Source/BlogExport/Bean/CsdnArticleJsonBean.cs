public class Data
{
    public string id { get; set; }
    public string title { get; set; }
    public int articleedittype { get; set; }
    public string description { get; set; }
    public string content { get; set; }
    public string markdowncontent { get; set; }
    public string tags { get; set; }
    public string categories { get; set; }
    public string channel { get; set; }
    public string type { get; set; }
    public int status { get; set; }
    public string readType { get; set; }
    public int use_vip_view { get; set; }
    public int use_fans_view { get; set; }
    public string reason { get; set; }
    public string resource_url { get; set; }
    public string original_link { get; set; }
    public bool authorized_status { get; set; }
    public bool check_original { get; set; }
}

public class CSDNObject
{
    public int result { get; set; }
    public Data data { get; set; }
    public string error { get; set; }
    public string content { get; set; }
    public bool status { get; set; }
}

