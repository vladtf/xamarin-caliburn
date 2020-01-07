using System;
using System.Collections.Generic;
using System.Text;

namespace XCMDEMO.NavigateToMessage
{
    public class NavigateToMessage
    {
        public NavigateToMessage(NavigateToEnum navigateTo)
        {
            NavigateToEnum = navigateTo;
        }
        public NavigateToEnum NavigateToEnum { get;}
    }
    public enum NavigateToEnum
    {
        HomeViewModel,
        SandBoxViewModel,
        WorkViewModel
    }
}
