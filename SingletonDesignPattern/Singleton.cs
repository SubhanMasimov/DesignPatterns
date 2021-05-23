namespace SingletonDesignPattern
{
    class Singleton
    {
        private static Singleton _singleton;

        private Singleton() { }

        public static Singleton GetSingleton()
        {
            return _singleton == null ? _singleton = new Singleton() : _singleton;
        }
    }
}
