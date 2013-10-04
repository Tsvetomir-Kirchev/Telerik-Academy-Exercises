using MobilePhone.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM[] phones = new GSM[]
            {
                new GSM("Glaxy S4", "Samsung", 899.99m,
                "Tsvetomir", new Battery("Samsung", BatteryType.LiIon,
                    8, 40), new Display(5.0f, 16000000)),
                    new GSM("Glaxy S4", "Samsung", 599.99m,
                "Jack", new Battery("HTC", BatteryType.NiCd,
                    8, 40), new Display(5.0f, 16000000)),
                    new GSM("Grand X", "ZTE", 199.99m,
                "John", new Battery("Samsung", BatteryType.NiMH,
                    8, 40), new Display(4.0f, 160000))
            };

            foreach (var gsm in phones)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine();
            }
            Console.WriteLine(GSM.Iphone4S.ToString());
            Console.WriteLine();

            GSM newGsm = new GSM("Glaxy S4", "Samsung", 899.99m,
                "Tsvetomir", new Battery("Samsung", BatteryType.LiIon,
                    8, 40), new Display(5.0f, 16000000));
            newGsm.AddCallToHistory(new Call(DateTime.Now, "08899288329", 220));
            newGsm.AddCallToHistory(new Call(DateTime.Now, "09921299218", 498));
            decimal totalPrice = newGsm.CalculateTotalPriceOfCalls(3.47m);
            Console.WriteLine("Total price: {0}", totalPrice);
        }
    }
}
