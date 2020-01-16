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
            Messages = new List<string>
            {
                "Hello World", "New message", "Type something"
            };
        }


        private List<string> _messages;

        public List<string> Messages
        {
            get { return _messages; }
            set { Set(ref _messages, value); }
        }


    }
}
