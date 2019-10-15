using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using BFound.HtmlToMarkdown;
using System.Text;
using BlogExport.XPath;

namespace BlogExport
{
    public partial class Form1 : Form
    {
        public static Form1 Singlton;

        public int CurrentPage = 1;
        public int PageCount;
        static ExportType exportType = ExportType.NULL;
        List<Article> articleList = new List<Article>();

        XPathBase xpath;

        public Form1()
        {
            Singlton = this;
            InitializeComponent();
            var items = Enum.GetValues(typeof(ExportType));
            foreach (var item in items)
            {
                if(! "NULL".Equals(item.ToString()))
                    comboBox1.Items.Add(item.ToString());
            }
        }


        private void BtnParse_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            if (CheckNull)
            {
                switch (exportType)
                {
                    case ExportType.NULL:
                        break;
                    case ExportType.CSDN:
                        xpath = new XPathCSDN();
                        break;
                    default:
                        break;
                }
                xpath.InitXPath(true,textBox1.Text, CurrentPage);
                PageCount = xpath.GetPageCount();
                articleList = xpath.GetArticleList();
                UpdateListViewUI();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            exportType = (ExportType)comboBox1.SelectedIndex;
        }
        private void BtnLast_Click(object sender, EventArgs e)
        {
            --CurrentPage;
             xpath.InitXPath(false, textBox1.Text, CurrentPage);
            UpdateListViewUI();
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            ++CurrentPage;
            xpath.InitXPath(true, textBox1.Text, CurrentPage);
            UpdateListViewUI();
        }
        private void BtnUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            xpath.InitXPath(false, textBox1.Text, CurrentPage);
            UpdateListViewUI();
        }
        private void 下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = GetExportPath();
            if (!string.IsNullOrEmpty(folderPath) && selectList.Count>0)
            {
                xpath.DownLoadSelects(folderPath, selectList);
            }
        }
        List<int> selectList = new List<int>(); 
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectList.Clear();
            if(listView1.SelectedItems.Count>0)
            {
                var selections = listView1.SelectedItems;
                foreach (ListViewItem item in selections)
                {
                    selectList.Add(int.Parse(item.Name));
                }
            }
        }

        private void BtnDownLoadCurrentPage_Click(object sender, EventArgs e)
        {
            string folderPath = GetExportPath();
            if (!string.IsNullOrEmpty(folderPath))
            {
                DownLoadCurrentPageHandler(folderPath);
                MessageBox.Show("下载完成");
            }
        }

        private void BtnDownLoadAll_Click(object sender, EventArgs e)
        {
            string folderPath = GetExportPath();
            if(!string.IsNullOrEmpty(folderPath))
            {
                for (int i = 1; i <= PageCount; i++)
                {
                    xpath.InitXPath(true, textBox1.Text, i);
                    DownLoadCurrentPageHandler(folderPath);
                }
            }
            MessageBox.Show("下载完成");
        }
        void DownLoadCurrentPageHandler(string folderPath)
        {
            var curList = new List<int>(); 
            for (int i = 0; i < articleList.Count; i++)
                curList.Add(articleList[i].Index);
            xpath.DownLoadSelects(folderPath, curList);
        }

        void UpdateListViewUI()
        {
            tip.Text = string.Format("第{0}页(共有{1}页)", CurrentPage, PageCount);
            listView1.Items.Clear();
            var list = xpath.GetArticleList();

            foreach (var item in list)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = item.Title;
                lv.Name = item.Index.ToString();
                lv.ImageIndex = 0;
                listView1.Items.Add(lv);
            }

            BtnLast.Enabled = true;
            BtnNext.Enabled = true;
            if (CurrentPage == 1)
            {
                BtnLast.Enabled = false;
            }
            if (CurrentPage == PageCount)
            {
                BtnNext.Enabled = false;
            }
            if(list.Count>0)
            {
                BtnDownLoadCurrentPage.Enabled = true;
                BtnDownLoadAll.Enabled = true;
            }
        }

        private string GetExportPath()
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                return folderBrowserDialog1.SelectedPath;
            return null;
        }
        bool CheckNull
        {
            get
            {
                if (exportType == ExportType.NULL)
                {
                    MessageBox.Show("请先选择类型");
                    return false;
                }
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("请输入网址！");
                    return false;
                }
                return true;
            }
        }

        public void cSDNUserTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = FileUtil.CreateCsdnConfig();
            System.Diagnostics.Process.Start("notepad.exe", path);
        }

        private void 如何使用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://blog.csdn.net/u013284706/article/details/82784802");
        }

        private void 提出意见ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = string.Format("mailto:{0}?Subject={1}", "852454151@qq.com", "BlogExport反馈");
            System.Diagnostics.Process.Start(msg);
        }

        private void 点个赞ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/TonyChenn/BlogExportTool");
        }
    }
}
