using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {

        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public string Model { get; set; }

        public int Capacity { get; set; }

        public List<CPU> Multiprocessor { get; set; }


        public int Count { get { return Multiprocessor.Count; } }
        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count + 1 <= Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            foreach (var item in Multiprocessor)
            {
                if (item.Brand == brand)
                {
                    Multiprocessor.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public CPU MostPowerful()
        {
            if (Multiprocessor.Count != 0)
            {
                CPU biggest = Multiprocessor[0];
                foreach (var item in Multiprocessor)
                {
                    if (item.Frequency > biggest.Frequency)
                    {
                        biggest = item;
                    }
                }
                return biggest;
            }
            return null;
        }

        public CPU GetCPU(string brand)
        {
            if(Multiprocessor.Count != 0)
            {
                foreach (var item in Multiprocessor)
                {
                    if(item.Brand == brand)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var item in Multiprocessor)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
