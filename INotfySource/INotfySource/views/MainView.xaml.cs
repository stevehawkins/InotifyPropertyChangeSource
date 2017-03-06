using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace INotfySource.views
{
	public partial class MainView : ContentPage
	{
		public MainView ()
		{
			InitializeComponent ();

            // set binding context here
            this.BindingContext = new viewmodels.ViewModel1();
		}
	}
}
