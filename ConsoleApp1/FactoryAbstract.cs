using System;

namespace FactoryAbstract
{
    public interface Worker
    {

        void Work();//

    }
    public interface AbstractFactory
    {
        DeveloperWorker makeDeveloperWorker();
        DesignerWorker makeDesignerWorker();
    }

    public interface DeveloperWorker : Worker
    {

    }

    public interface DesignerWorker : Worker
    {

    }


    public class OutsourceDesignerWorker : DesignerWorker
    {

        public void Work()
        {
            Console.WriteLine("im OutsourceDesignerWorker");   // TODO: Implement workk() method.
        }
    }

    public class NativeDesignerWorker : DesignerWorker
    {

        public void Work()
        {
            Console.WriteLine("im NativeDesignerWorker");   // TODO: Implement workk() method.
        }

    }


   
    public class NativeDeveloperWorker : DeveloperWorker
    {

        public void Work()
        {
            Console.WriteLine("im NativeDeveloperWorker");//

        }
    }



    public class NativeWorkerFactory : AbstractFactory
    {
        public DesignerWorker makeDesignerWorker()
        {
            return new NativeDesignerWorker();
        }

        public DeveloperWorker makeDeveloperWorker()
        {
            return new NativeDeveloperWorker();
        }
    }
    public class OutsourceWorkerFactory : AbstractFactory
    {
        public DesignerWorker makeDesignerWorker()
        {
            return new NativeDesignerWorker();
        }

        public DeveloperWorker makeDeveloperWorker()
        {
            return new NativeDeveloperWorker();
        }
    }


    //пример использования в методе main
    //var designer = new DesignerFactory().Make();
    //var developer = new DeveloperFactory().Make();//

    //developer.Work();

    //        designer.Work();
    //        Console.ReadLine();

}




