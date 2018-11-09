using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using GuruTest.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(GuruTest.Controls.ChatBubbleView), typeof(ChatBubbleViewRenderer))]
namespace GuruTest.Droid.Renderers
{
    public class ChatBubbleViewRenderer : VisualElementRenderer<StackLayout>
    {

        public ChatBubbleViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<StackLayout> e)
        {
            base.OnElementChanged(e);
            SetCornerRadius();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if(e.PropertyName == "Radius" || e.PropertyName == nameof(Element.BackgroundColor))
            {
                SetCornerRadius();
            }

        }




        private void SetCornerRadius()
        {
            var elm = Element as GuruTest.Controls.ChatBubbleView;
            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadii(new float[] { 0f, 0f, elm.Radius*2, elm.Radius * 2, elm.Radius * 2, elm.Radius * 2, elm.Radius * 2, elm.Radius * 2 });


            var color = (Background as ColorDrawable)?.Color ?? Android.Graphics.Color.Red;

            gd.SetColor(color);
           
            
            this.Background = gd;
        }
    }
}
