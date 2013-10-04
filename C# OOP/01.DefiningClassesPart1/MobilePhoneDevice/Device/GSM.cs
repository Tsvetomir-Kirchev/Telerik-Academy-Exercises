using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device
{
    public class GSM
    {
        public static GSM Iphone4S = new GSM("iPhone 4s", "Apple", 1500.00m,
            "Nobody", new Battery("chine", BatteryType.LiIon, 6, 20), new Display(4.6f, 16000000));

        public List<Call> CallHistory { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public decimal Price { get; set; }

        public string Owner { get; set; }

        public Battery BatteryCharacterisitcs { get; set; }

        public Display DisplayCharacterisitcs { get; set; }

        public GSM(string model, string manufacturer, decimal price,
            string owner, Battery baterry, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.BatteryCharacterisitcs = baterry;
            this.DisplayCharacterisitcs = display;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, Display display)
            : this(model, manufacturer, price, null, null, display)
        {

        }

        public void AddCallToHistory(Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCallFromHistory(Call call)
        {
            if (CallHistory.Contains(call))
            {
                CallHistory.Remove(call);
            }
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public decimal CalculateTotalPriceOfCalls(decimal price)
        {
            int totalTime = 0;
            foreach (var call in CallHistory)
            {
                totalTime += call.Duration;
            }

            return (totalTime / 60) * price;
        }

        public override string ToString()
        {
            return String.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}" +
                "\nOwner: {3}\nBattery type: {4}\nDisplay Size: {5}",
                this.Model, this.Manufacturer, this.Price, this.Owner,
                this.BatteryCharacterisitcs.Type, this.DisplayCharacterisitcs.Size);
        }
    }
}
