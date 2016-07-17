using System;

using Xamarin.Forms;

namespace PdfViewerXamForms
{
	public class PdfViewerPage : ContentPage
	{
		public PdfViewerPage ()
		{
			Padding = new Thickness (0, 20, 0, 0);
			Content = new StackLayout {
				Children = {
					new Button {
						Text = "Button"
					},
					new CustomWebView {
						Uri = "samplepdf.pdf",
						HorizontalOptions = LayoutOptions.FillAndExpand,
						VerticalOptions = LayoutOptions.FillAndExpand,
					}
				}
			};
		}
	}
}


