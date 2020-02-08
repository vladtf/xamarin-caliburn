namespace XCMDEMO.Models
{
    public class SingletonTestModel
    {
        private static SingletonTestModel singletonTestModel;

        public string HashCode
        {
            get
            {
                if (singletonTestModel == null)
                {
                    return "Not instanciated.";
                }
                return singletonTestModel.GetHashCode().ToString();
            }
        }

        private SingletonTestModel()
        {
        }

        public static SingletonTestModel GetInstance()
        {
            if (singletonTestModel == null)
            {
                singletonTestModel = new SingletonTestModel();
            }

            return singletonTestModel;
        }

        public static SingletonTestModel GetNewInstance()
        {
            singletonTestModel = new SingletonTestModel();

            return singletonTestModel;
        }
    }
}