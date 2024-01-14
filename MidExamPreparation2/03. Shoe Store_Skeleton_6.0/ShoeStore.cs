using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int capacity)
        {
            Name = name;
            StorageCapacity = capacity;
            Shoes = new List<Shoe>();
        }

        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes { get; private set; }

        public int Count { get { return Shoes.Count; } }



        public string AddShoe(Shoe shoe)
        {
            if(Shoes.Count + 1 > StorageCapacity)
            {
                return "No more space in the storage room.";
            }

            Shoes.Add(shoe);
            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
        }
        public int RemoveShoes(string material)
        {
            return Shoes.RemoveAll(x => x.Material == material);
        }
        public List<Shoe> GetShoesByType(string type)
        {
            return Shoes.Where(x => x.Type.ToLower() == type.ToLower()).ToList();
        }
        public Shoe GetShoeBySize(double size)
        {
            return Shoes.FirstOrDefault(x => x.Size == size);
        }
        public string StockList(double size, string type)
        {
            StringBuilder sb = new StringBuilder();
            if(Shoes.Any(x=>x.Size == size && x.Type == type))
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (var item in Shoes.Where(x => x.Size == size && x.Type == type))
                {
                    sb.AppendLine(item.ToString());
                }
            }
            else
            {
                sb.AppendLine("No matches found!");
            }
            return sb.ToString().Trim();
        }

    }
}
