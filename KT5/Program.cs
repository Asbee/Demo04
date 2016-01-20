using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            OnOFF onoff = new OnOFF();
            Volume volume = new Volume();
            Frequ frequ = new Frequ();

            while (true)
            {
                Console.WriteLine("Radio");
                Console.WriteLine("1.Turn radio ON/OFF");
                Console.WriteLine("2.Adjust Volume");
                Console.WriteLine("3.Adjust Frequency");
                Console.Write("Choose: ");
                n1 = int.Parse(Console.ReadLine());

                if (n1 == 1)
                {
                    if (onoff.OnOff != false)
                    {
                        onoff.OnOff = false;
                        Console.WriteLine("Radio is OFF");
                    }
                    else
                    {
                        onoff.OnOff = true;
                        Console.WriteLine("Radio is ON");
                    }
                }
                if (n1 == 2)
                {
                    if (onoff.OnOff == false)
                    {
                        Console.WriteLine("RADIO NOT ON!!! ");                   
                    }
                    else
                    {
                        Console.Write("Adjust your volume 0-9: ");
                        volume.Volumee = int.Parse(Console.ReadLine());
                    }
                }
                if (n1 == 3)
                {
                    if (onoff.OnOff == false)
                    {
                        Console.WriteLine("RADIO NOT ON!!! ");
                    }
                    else
                    {
                        Console.Write("Adjust your Frequency 2000.0 - 26000.0 ");
                        frequ.Fre = int.Parse(Console.ReadLine());
                    }
                    
                    
                }
            }

            
        }
    }
}
