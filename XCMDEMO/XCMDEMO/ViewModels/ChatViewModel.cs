using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace XCMDEMO.ViewModels
{
    public class ChatViewModel : Screen, IChildViewModel
    {
        public string Title { get; set; } = "Chat";
        public ChatViewModel()
        {

        }


    }
}
