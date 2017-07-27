using System;
using System.Collections.Generic;
using System.Text;
using Android.Locations;
using Xamarin.Forms;

namespace HybridWebViewTest
{
    public class HybridWebView:WebView
    {
        public event EventHandler<EventArgs> CallAction; 
        public void SendClick(string data)
        {
            CallAction?.Invoke(this,new EventArgs());
        }
    }
}
