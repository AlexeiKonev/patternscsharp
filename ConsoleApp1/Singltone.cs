namespace ConsoleApp1
{

    class Singleton
    {
        private static Singleton instance;
        private string name = "Boris";

        public string Name  { get => name; set => name = value; }

       
        private Singleton()
        { }

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
     
}
