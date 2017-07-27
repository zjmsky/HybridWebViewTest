using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HybridWebViewTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    webView.Source = string.Format("file:///android_asset/Content/{0}", "index.html");
            webView.CallAction += WebView_CallAction;
            //btn.Clicked += Btn_Clicked;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            webView.Eval(string.Format("print({0})", "test"));
        }

        private void WebView_CallAction(object sender, EventArgs e)
        {
            object test = "http://www.baidu.com";
            webView.Eval(string.Format("print('" + test + "')"));
        }

	    void OnCallJavaScriptButtonClicked(object sender, EventArgs e)
	    {
            webView.Eval(string.Format("print({0})", 5));
            //webView.Eval(string.Format("testInvokeJs({0})", "test"));
        }
    }
}
