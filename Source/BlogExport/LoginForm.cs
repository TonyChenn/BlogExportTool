using BlogExport.Util;
using System;
using System.Windows.Forms;

namespace BlogExport
{
    public partial class LoginForm : Form
    {
        ExportType type = ExportType.NULL;

        private static LoginForm _instance = null;

        public static LoginForm GetInstance(string title,ExportType type)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new LoginForm();

            _instance.Text = title;
            _instance.type = type;
            return _instance;
        }

        private LoginForm()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            switch(type)
            {
                case ExportType.CSDN:
                    CSDNLoginHandler();
                    break;
                default:
                    break;
            }
        }

        private void CSDNLoginHandler()
        {

            CsdnLogin login = new CsdnLogin();
            login.loginType = "1";
            login.userIdentification = Tb_Uid.Text;
            login.pwdOrVerifyCode = Tb_Pwd.Text;
            login.uaToken = "";
            login.webUmidToken = "";

            
            string json = fastJSON.JSON.ToJSON(login);
            string url = "https://passport.csdn.net/v1/register/pc/login/doLogin";
            string refer = "https://passport.csdn.net/login?code=public";
            string host = "passport.csdn.net";
            var cc = HttpUtils.GetCookieContainter(refer, refer, false, host);
            string content = HttpUtils.PostDataAndGetData(url, json, refer, host, true, cc);
            Console.WriteLine(content);
        }
    }
}
