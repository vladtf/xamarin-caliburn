using Caliburn.Micro;
using XCMDEMO.Models;

namespace XCMDEMO.ViewModels
{
    public class SingletonDemoViewModel : Screen, IChildViewModel
    {
        private SingletonTestModel instance;

        public SingletonDemoViewModel()
        {
        }

        public void GetInstance()
        {
            instance = SingletonTestModel.GetInstance();
            NotifyOfPropertyChange(() => HashString);
        }

        public void GetNewInstance()
        {
            instance = SingletonTestModel.GetNewInstance();
            NotifyOfPropertyChange(() => HashString);
        }

        public string HashString
        {
            get
            {
                if (instance == null)
                {
                    return "Object not instanciated";
                }
                return $"Hash : {instance.HashCode}";
            }
        }

        public string Title { get; set; } = "Singleton Demo";
    }
}