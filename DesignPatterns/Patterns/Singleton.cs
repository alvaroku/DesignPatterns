namespace DesignPatterns.Patterns
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();// Objeto de bloqueo para sincronización

        // Private constructor to prevent instantiation from outside
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                // Bloquear el objeto _lock para asegurar el acceso exclusivo a la instancia
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton instance doing something.");
        }
    }
}
