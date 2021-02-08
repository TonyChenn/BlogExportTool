using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using BlogExport.Util;

namespace BlogExport.XPath
{
    public class XPathCSDN :XPathBase
    {
        string m_url;
        static List<Article> m_articleList = new List<Article>();
        int m_totalPostCount;
        int m_perPagePostCount;
        int m_pageCount;
        string UserName, Token;

        //账号密码登陆
        //bool IsLogin = false;

        public override List<Article> GetArticleList()
        {
            return m_articleList;
        }
        public override int GetPageCount()
        {
            return m_pageCount;
        }
        /// <summary>
        /// 初始化xPath
        /// </summary>
        public override void InitXPath(bool firstTime, string url, int pageCount = 1)
        {
            this.m_url = url;
            if(firstTime)
            {
                PageCount = "//div[@class='ui-paging-container']/ul/li[last()-2]";
                PerPageArticalList = "//div[@class='article-item-box csdn-tracking-statistics']";
                Title = "//h4/a";
                GetTitleXPath = "//h1[@class='title-article']";
                WriteTime = "//div/p[1]/span";
                Content = "//div[@id='article_content']";
                tags = "//a[@class='tag-link']";
            }
            ParsePageData(pageCount);
        }

        /// <summary>
        /// 按页解析
        /// </summary>
        /// <param name="pageNum"></param>
        protected override void ParsePageData(int pageNum)
        {
            m_url = m_url.TrimEnd('/') + "/article/list/" + pageNum;
            var Node = HttpUtils.GetHtmlNodeFromUrl(m_url);

            if (pageNum == 1)
            {
                string html = Node.InnerHtml;
                m_totalPostCount = JsUtil.GetJsNumVariable(html, @"var\s+listTotal\s*?=\s*?\d{1,3}");
                if (m_totalPostCount == 0)
                {
                    WinformUtil.ShowDialog("提示", "空空如也");
                    return;
                }
                m_perPagePostCount = JsUtil.GetJsNumVariable(html, @"var\s+pageSize\s*?=\s*?\d{1,3}");
                m_pageCount = m_totalPostCount / m_perPagePostCount + (m_totalPostCount % m_perPagePostCount > 0 ? 1 : 0);
            }

            var postNodes = Node.SelectNodes(PerPageArticalList);
            if (postNodes != null)
            {
                int index = 0;
                m_articleList.Clear();
                foreach (var item in postNodes)
                {
                    var doc = new HtmlDocument();
                    doc.LoadHtml(item.InnerHtml);

                    var titleNode = doc.DocumentNode.SelectSingleNode(Title);
                    var timeNode = doc.DocumentNode.SelectSingleNode(WriteTime);

                    Article article = new Article();
                    StringBuilder builder = new StringBuilder(titleNode.InnerText);
                    builder.Replace("\n", "");
                    builder.Replace(" ", "");
                    article.Title = builder.ToString();
                    article.Time = timeNode.InnerText;
                    article.Link = titleNode.Attributes["href"].Value;
                    article.Id = GetIdByUrl(article.Link);
                    article.Index = index;
                    m_articleList.Add(article);
                    ++index;
                }
            }
        }

        /// <summary>
        /// 解析单个博文
        /// </summary>
        /// <param name="url"></param>
        protected override void ParsePostData(string url)
        {
            
        }

        public override void DownLoadSelects(string folder, List<int> selectList)
        {
            string error = "";
            for (int i = 0; i < selectList.Count; i++)
            {
                int index = selectList[i];
                try
                {
                    
                    string url = "https://mp.csdn.net/mdeditor/getArticle?id=" + m_articleList[index].Id;

                    FileUtil.GetToken("csdn_config.dat", out UserName, out Token);
                    //bool isLogin = CheckLogin();
                    //if (!isLogin)
                    //{
                    //    LoginForm.GetInstance("CSDN登陆", ExportType.CSDN).Show();
                    //    return;
                    //}

                    if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Token))
                    {
                        System.Windows.Forms.MessageBox.Show("请先配置UserName和UserToken");
                        Form1.Singlton.cSDNUserTokenToolStripMenuItem_Click(null, null);
                        break;
                    }

                    CookieContainer cc = HttpUtils.GetCookieContainter(url);
                    cc.Add(new Cookie("UserName", UserName, "/", ".csdn.net"));
                    cc.Add(new Cookie("UserToken",Token , "/", ".csdn.net"));

                    var req = (HttpWebRequest)WebRequest.Create(url);
                    req.Method = "POST";
                    req.UserAgent = HttpUtils.RandomUserAgent();
                    req.ContentType = "text/html;charset=UTF-8";
                    req.CookieContainer = cc;
                    var resp = (HttpWebResponse)req.GetResponse();
                    var stream = resp.GetResponseStream();
                    var reader = new StreamReader(stream, Encoding.UTF8);
                    var msg = reader.ReadToEnd();
                    reader.Close();
                    stream.Close();
                    
                    var jsonNode = fastJSON.JSON.ToObject<CSDNObject>(msg);

                    if (jsonNode.status)
                        FileUtil.WriteMarkDown(folder, jsonNode.data.title, jsonNode.data.tags, jsonNode.data.categories, jsonNode.data.markdowncontent, m_articleList[i].Time);
                    else
                        System.Windows.Forms.MessageBox.Show(jsonNode.content + "重新配置Token信息");
                }
                catch (Exception ex)
                {
                    error += ex.Message;
                }
            }
            if (!string.IsNullOrEmpty(error))
            {
                System.Windows.Forms.MessageBox.Show(error/*"Fuck,Token过期了，重新粘贴下吧"*/);
                Form1.Singlton.cSDNUserTokenToolStripMenuItem_Click(null, null);
            }
        }

        /// <summary>
        /// 获取文章ID
        /// </summary>
        string GetIdByUrl(string url)
        {
            string[] temp = url.Split('/');
            int length = temp.Length;
            return temp[length - 1];
        }

        /// <summary>
        /// 检查登录
        /// </summary>
        protected override bool CheckLogin()
        {
            throw new NotImplementedException();
        }
    }
}
