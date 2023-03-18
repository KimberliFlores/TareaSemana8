using System;
using System.Linq;
using TareaSemana8.Models;
namespace TareaSemana8
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto pro = new Producto();
            using (AlmacenContext db = new AlmacenContext())
            {
                Console.WriteLine("Digita el nombre del producto");
                pro.Nombre = Console.ReadLine();
                Console.WriteLine("Digita la descripcion del producto");
                pro.Descripcion = Console.ReadLine();
                Console.WriteLine("Digita el precio del producto");
                pro.Precio = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Digita el stock del producto");
                pro.Stock = int.Parse(Console.ReadLine());
                db.Add(pro);
                db.SaveChanges();
                Console.WriteLine("Poducto ingresado insertado!\n");

                var lis = db.Productos.ToList();
                foreach (var producto in lis)
                {
                    Console.WriteLine("\nNombre: " + producto.Nombre);
                    Console.WriteLine("Descripcion: " + producto.Descripcion);
                    Console.WriteLine("Precio: " + producto.Precio);
                    Console.WriteLine("Stock: " + producto.Stock);
                }

            }
        }
    }
}
