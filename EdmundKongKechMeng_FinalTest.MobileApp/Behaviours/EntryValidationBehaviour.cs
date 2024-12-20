using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdmundKongKechMeng_FinalTest.MobileApp.Behaviours
{
    public class EntryValidationBehavior : Behavior<Entry>
    {
        public static readonly BindableProperty RegexProperty =
            BindableProperty.Create(nameof(Regex), typeof(string), typeof(EntryValidationBehavior));

        public static readonly BindableProperty IsValidProperty =
            BindableProperty.Create(nameof(IsValid), typeof(bool), typeof(EntryValidationBehavior), false);

        public string Regex
        {
            get => (string)GetValue(RegexProperty);
            set => SetValue(RegexProperty, value);
        }

        public bool IsValid
        {
            get => (bool)GetValue(IsValidProperty);
            private set => SetValue(IsValidProperty, value);
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += OnTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue) || string.IsNullOrEmpty(Regex))
            {
                IsValid = false;
                return;
            }

            IsValid = System.Text.RegularExpressions.Regex.IsMatch(e.NewTextValue, Regex);
            ((Entry)sender).BackgroundColor = IsValid ? Colors.Transparent : Colors.LightPink;
        }
    }
}
