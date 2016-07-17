using System;
using Xamarin.Forms.Platform.Android;
using Android.Webkit;
using System.Net;
using Xamarin.Forms;
using PdfViewerXamForms;
using PdfViewerXamForms.Droid;

[assembly: ExportRenderer (typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace PdfViewerXamForms.Droid
{
	public class CustomWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.WebView> e)
		{
			base.OnElementChanged (e);

			if (e.NewElement != null) {
				var customWebView = Element as CustomWebView;
				Control.Settings.AllowUniversalAccessFromFileURLs = true;
				Control.LoadUrl (string.Format ("file:///android_asset/pdfjs/web/viewer.html?file={0}", string.Format ("file:///android_asset/Content/{0}", WebUtility.UrlEncode (customWebView.Uri))));
			}
		}
	}
}

