using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using XCMDEMO.Models;

namespace XCMDEMO.ViewModels
{
    class HomeViewModel : Screen,IChildViewModel
    {

        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();

        public HomeViewModel()
        {
            //var result = SQLDataAcces.GetPeople();

            People.Add(new PersonModel { FirstName = "John", LastName = "Smith" });
            People.Add(new PersonModel { FirstName = "Will", LastName = "Johnson" });
            People.Add(new PersonModel { FirstName = "Joseph", LastName = "Smith" });
        }

        
        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { Set(ref _people, value); }
        }

        public string DisplayName { get; set; } = "Home";

    }
}
