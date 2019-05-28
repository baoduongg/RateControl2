using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DemoRating2
{
    public class RateControl : StackLayout
    {
        private Image _image;
       
        public string ImageCheck
        {
            get => (string)GetValue(ImageCheckProperty);
            set => SetValue(ImageCheckProperty, value);
        }
        public string ImageUnCheck
        {
            get => (string)GetValue(ImageUnCheckProperty);
            set => SetValue(ImageUnCheckProperty, value);
        }
        private readonly BindableProperty ImageCheckProperty =
            BindableProperty.Create("ImageCheck", typeof(string), typeof(RateControl), string.Empty,
                BindingMode.OneWay, propertyChanged: ImagePropertyChanged);

         private readonly BindableProperty ImageUnCheckProperty =
            BindableProperty.Create("ImageUnCheck", typeof(string), typeof(RateControl), string.Empty,
                BindingMode.OneWay, propertyChanged: ImagePropertyChanged);

        private static void ImagePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RateControl)bindable;
            if (control != null)
            {
               
                control.Update();
            }
        }

        public bool IsSelected
        {
            get => (bool)GetValue(IsSelectProperty);
            set => SetValue(IsSelectProperty, value);
        }
      
        private readonly BindableProperty IsSelectProperty =
            BindableProperty.Create("IsSelected", typeof(bool), typeof(RateControl), false, 
                BindingMode.TwoWay, propertyChanged: IsSelectPropertyChanged);

        private static void IsSelectPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (RateControl)bindable;
            if(control!= null)
            {
                control.IsSelected = (bool)newValue;
                control.Update();
            }
        }

        private void Update()
        {
            _image.Source = IsSelected ? ImageCheck : (ImageSource)ImageUnCheck;
        }

        public RateControl()
        {
           
            _image = new Image
            {
                Source = ImageUnCheck,
                Aspect = Aspect.Fill,
                HeightRequest = 50,
                WidthRequest = 50,
                
                
            };
          
            Children.Add(_image);
        }
    }
}
