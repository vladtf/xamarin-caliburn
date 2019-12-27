using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace XCMDEMO.ViewModels
{
    public class HomeViewModel : Screen
    {
        private string _mainText;

        public HomeViewModel()
        {
            MainText = "Hello World!";
        }

        public string MainText
        {
            get { return _mainText; }
            set
            {
                SetField(ref _mainText, value);
            }
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!object.Equals(field, value))
            {
                field = value;
                NotifyOfPropertyChange(propertyName);
                return true;
            }
            return false;
        }
    }
}
