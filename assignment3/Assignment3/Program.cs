using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>();
            list.Add(new Product() { name = "lettuce",price=10.5f,quantity=50,type="Leafy green" });
            list.Add(new Product() { name = "cabbage", price = 20, quantity = 100, type = "Cruciferous" });
            list.Add(new Product() { name = "pumpkin", price = 30f, quantity = 30, type = "Marrow" });
            list.Add(new Product() { name = "cauliflowe", price = 10.5f, quantity = 25, type = "Cruciferous" });
            list.Add(new Product() { name = "zucchin", price = 20.5f, quantity = 50, type = "Marrow" });
            list.Add(new Product() { name = "yam", price = 30f, quantity = 50, type = "Root" });
            list.Add(new Product() { name = "spinach", price = 10f, quantity = 100, type = "Leafy green" });
            list.Add(new Product() { name = "broccoli", price = 20.2f, quantity = 75, type = "Cruciferous" });
            list.Add(new Product() { name = "garlic", price = 30f, quantity = 20, type = "Leafy green" });
            list.Add(new Product() { name = "silverbeet", price = 10f, quantity = 50, type = "Marrow " });

            //addinng new item in list
            Console.WriteLine(list.Count);
            list.Add(new Product() { name = "Potato", price = 10f, quantity = 50, type = "Root " });
            foreach (var item in list)
            {
                Console.WriteLine(item.name);//show all item
            }
            Console.WriteLine(list.Count);

            //showin item whose type is leafy green

            foreach (var item in list)
            {
                if(item.type== "Leafy green")
                Console.WriteLine(item.name);
            }
            
            for (int i=0; i<list.Count;i++)
            {
                if (list[i].name == "garlic")
                    list.Remove(list[i]);
            }

              Console.WriteLine(list.Count);//show total item

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].name == "cabbage")
                {
                    list[i].quantity += 50;
                    Console.WriteLine("Quantity of"+list[i].name+":"+ list[i].quantity);
                }
            }

         /*   for (int i = 0; i < list.Count; i++)
            {
                if (list[i].name == "lettuce")
                    list[i].quantity=1;

                if (list[i].name == "zucchini")
                    list[i].quantity = 2;
                if (list[i].name == "broccoli ")
                    list[i].quantity = 1;
            }
*/
            float sum = 0f;




            sum = 10.5f + (2 * 20.5f) + 20.2f;
            sum = (float)Math.Round(sum);
            Console.WriteLine("Total amount to pay="+sum);

            Console.ReadLine();
        }
    }
}
