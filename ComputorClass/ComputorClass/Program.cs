using System;

namespace ComputorClass
{
    class Pc
    {
        static void Main(string[] args)
        {

            var mouse = new Input("logitech");
            var power = new Support("pw1000");
            var ssd = new Hardisk("sata m.2");
            var cpu = new Processsor("Intel core i9");
            var ram = new Ram("HyperX");


            InputObj(mouse);
            InputObj(power);
            InputObj(ssd);



        }

        static void InputObj(IHardware input)
        {
            Console.WriteLine(input.SerialNumber);
            Console.WriteLine(input.GetName());
        }
    }
}
