using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoRating2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoRating : ContentPage
    {
        int RatePoint = 3;
        int StarCount = 5;

        public DemoRating ()
		{
			InitializeComponent ();
            AddStar();

           
        }
        void AddStar()
        {
            for (int i = 0; i < StarCount; i++)
            {
                if (i < RatePoint)
                {
                    stackstar.Children.Add(new RateControl
                    {

                        ImageUnCheck = "unStaricon.png",
                        ImageCheck = "Staricon.png",
                        IsSelected = true,

                    });
                }
                else
                {
                    stackstar.Children.Add(new RateControl
                    {

                        ImageUnCheck = "unStaricon.png",
                        ImageCheck = "Staricon.png",
                        IsSelected = false,

                    });
                }
            }
        }
    }




}
