using System;
using Lab2_Builder.Builders;

namespace Lab2_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new SH_ControlPanel();
            Director director = new Director(builder);
            director.Construct();
            SmartHouse SH = builder.GetSmartHouse();
            Console.WriteLine(SH.ToString());

            builder = new SH_RemoteController();
            director = new Director(builder);
            director.Construct();
            SH = builder.GetSmartHouse();
            Console.WriteLine(SH.ToString());

            builder = new SH_MobileDevices();
            director = new Director(builder);
            director.Construct();
            SH = builder.GetSmartHouse();
            Console.WriteLine(SH.ToString());
        }
    }
}
