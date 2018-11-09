using System;
using Xamarin.Forms;

namespace GuruTest
{
    public class ChatTemplateSelector : DataTemplateSelector
    {
        public ChatTemplateSelector()
        {
        }

        public DataTemplate FromTemplate { get; set; }
        public DataTemplate ToTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((string)item) == "From"?FromTemplate : ToTemplate;
        }
    }
}
