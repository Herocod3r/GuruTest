using System;

using Xamarin.Forms;

namespace GuruTest.Controls
{
    public class ChatBubbleView : StackLayout
    {
        public ChatBubbleView()
        {
           
        }


        public static readonly BindableProperty RadiusProperty = BindableProperty.Create(
            "Radius", typeof(float), typeof(ChatBubbleView), 0f, propertyChanged: OnRadiusChanged);

        static void OnRadiusChanged(BindableObject bindable, object oldValue, object newValue)
        {

        }

        public float Radius
        {
            get { return (float)GetValue(RadiusProperty); }
            set { SetValue(RadiusProperty, value); }
        }

    }
}

