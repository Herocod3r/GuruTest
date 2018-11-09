using System;
using System.ComponentModel;
using CoreAnimation;
using GuruTest.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(GuruTest.Controls.ChatBubbleView), typeof(ChatBubbleViewRenderer))]
namespace GuruTest.iOS.Renderers
{
    public class ChatBubbleViewRenderer : VisualElementRenderer<StackLayout>
    {
        public ChatBubbleViewRenderer()
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

            if (e.PropertyName == "Radius" || e.PropertyName == nameof(Element.BackgroundColor))
            {
                SetCornerRadius();
            }

        }


        private void SetCornerRadius()
        {
            try
            {
                var elm = Element as GuruTest.Controls.ChatBubbleView;

                ClipsToBounds = true;
                Layer.AllowsEdgeAntialiasing = true;
                Layer.EdgeAntialiasingMask = CAEdgeAntialiasingMask.All;
                Layer.CornerRadius = new nfloat(elm.Radius);
                Layer.MaskedCorners = (CoreAnimation.CACornerMask)14;
            }
            catch (Exception ex)
            {

            }
           
        }
    }
}
