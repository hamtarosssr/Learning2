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
            var ram1 = new Ram("HyperX");
            var ram = new Ram("samsung");
            var keyboard = new Input("RK75");
            var monitor = new Output("asus monitor");
            
            InputObj(mouse);
            InputObj(power);
            InputObj(ssd);
            InputObj(cpu);
            InputObj(ram);



        }

        static void InputObj(IHardware input)
        {
            Console.WriteLine(input.SerialNumber);
            Console.WriteLine(input.GetName());
        }
    }
}
