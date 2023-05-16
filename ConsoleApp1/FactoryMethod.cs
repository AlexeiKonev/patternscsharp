using System;

namespace FactoryMethod
{


  public  interface Worker
    {

        void Work();//

    }

    class Designer : Worker
    {

        public void Work()
        {
            Console.WriteLine("im desiner");//

        }
    }
    class Developer : Worker
    {

        public void Work()
        {
            Console.WriteLine("im Developer");//

        }
    }
    class DesignerFactory : FactoryWorker
    {

        public Worker Make()
        {
            return new Designer();  // TODO: Implement make() method.
        }
    }
    class DeveloperFactory : FactoryWorker
    {

        public Worker Make()
        {
            return new Developer(); // TODO: Implement make() method.
        }
    }

    public interface FactoryWorker
    {
         Worker Make();
    }
    //пример использования в методе main
    //var designer = new DesignerFactory().Make();
    //var developer = new DeveloperFactory().Make();//

    //developer.Work();

    //        designer.Work();
    //        Console.ReadLine();

}




