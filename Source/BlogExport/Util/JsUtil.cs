using System.Text.RegularExpressions;
public class JsUtil
{
    public static int GetJsNumVariable(string html, string pattern)
    {
        int count = 0;
        Match match = Regex.Match(html, pattern);
        if (match.Success)
        {
            //match.value:  var listTotal = 63
            string[] values = match.Value.Split('=');
            int.TryParse(values[1].Trim(' '), out count);
        }
        return count;
    }
}
