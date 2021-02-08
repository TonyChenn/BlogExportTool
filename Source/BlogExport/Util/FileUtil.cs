using System;
using System.IO;
using System.Text;

public class FileUtil
{

    public static string CreateCsdnConfig()
    {
        string path = "csdn_config.dat";

        if (!File.Exists(path))
        {
            var fs = File.Create(path);
            fs.Close();
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine("UserName : ");
            writer.WriteLine("UserToken : ");
            writer.WriteLine();
            writer.WriteLine("//请在UserName后面粘贴你的用户名");
            writer.WriteLine("//请在UserToken后面粘贴你的Token");
            writer.WriteLine("//不会使用？ https://blog.csdn.net/u013284706/article/details/82784802");
            writer.WriteLine("觉得不错，记得去Github给我点个赞哟");
            writer.Close();
        }
        return path;
    }
    public static void GetToken(string path,out string UserName,out string Token)
    {
        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);

            string[] u = reader.ReadLine().Replace(" ", "").Split(':');
            UserName = u[1];

            string[] t = reader.ReadLine().Replace(" ", "").Split(':');
            Token = t[1];
        }
        else
        {
            UserName = "";
            Token = "";
        }
    }
    public static string WriteMarkDown(string folder, string title,string tags,string categories, string content,string time)
    {
        string error = "";
        try
        {
            StringBuilder builder = new StringBuilder(title);
            builder.Replace(@"\", "");
            builder.Replace(@"/", "");
            builder.Replace(@":", "");
            builder.Replace(@"*", "");
            builder.Replace(@"?", "");
            builder.Replace("\"", "");
            builder.Replace(@"<", "");
            builder.Replace(@">", "");
            builder.Replace(@"|", "");
            builder.Replace(" ", "");

            string filePath = folder + "\\" + builder.ToString() + ".md";
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("---");
            writer.WriteLine("title: " + title);
            writer.WriteLine("date: " + time);
            writer.WriteLine("tags: "+tags);
            writer.WriteLine("---");
            writer.Write(content);
            writer.Flush();
            writer.Close();
            fs.Close();
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
        return error;
    }
}