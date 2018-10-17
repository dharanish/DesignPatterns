namespace DesignPatterns.Singleton_Pattern
{
    public static class SingletonGeneric<T> where T : new()

    {
        private static T _singletonObject;

        public static T SingleInstance
        {
            get
            {
                if (_singletonObject == null)
                {
                    _singletonObject = new T();
                }

                return _singletonObject;
            }
        }
    }

    //Use static methods in instance classes only when those methods are not dependent on instance variables.
    //If they are dependent on instance variables then use instance methods.

    public sealed class SingletonEagar
    {
        private static SingletonEagar singletonEagar = new SingletonEagar();

        private SingletonEagar()
        {

        }

        public SingletonEagar GetInstance()
        {
            return singletonEagar;
        }
    }

    public class TestClass
    {
        public static string Name;
    }
}
