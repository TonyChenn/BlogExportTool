using System.Collections.Generic;

namespace BlogExport.XPath
{
    public abstract class XPathBase
    {
        /// <summary>
        /// 页数
        /// </summary>
        public string PageCount;
        /// <summary>
        /// 每页获取文章的内容
        /// </summary>
        public string PerPageArticalList;
        /// <summary>
        /// 文章标题
        /// </summary>
        public string Title;
        /// <summary>
        /// 文件名
        /// </summary>
        public static string GetTitleXPath;
        /// <summary>
        /// 发布时间
        /// </summary>
        public string WriteTime;
        /// <summary>
        /// 标签
        /// </summary>
        public string tags;
        /// <summary>
        /// 文章内容
        /// </summary>
        public static string Content;


        public abstract int GetPageCount();
        //public abstract int GetTotalPageCount();
        //public abstract string GetTitle();
        //public abstract string GetFileName();
        //public abstract string GetWriteTime();
        //public abstract string GetContent();
        public abstract List<Article> GetArticleList();
        public abstract void InitXPath(bool firstTime, string url, int pageCount = 1);

        protected abstract void ParsePageData(int pageNum);
        protected abstract void ParsePostData(string url);
        public abstract void DownLoadSelects(string folder, List<int> selectList);
        protected abstract bool CheckLogin(); 
    }
}
