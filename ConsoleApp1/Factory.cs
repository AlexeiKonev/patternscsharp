namespace ConsoleApp1
{
     

  public  class Worker
    {
        private string name;

        public string Name { get => name; set => name = value; }
    }
    public class WorkerFactory
    {

        public static Worker Make()
        {
            return new Worker();//

        }
    }
}


