using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class TelefonoInteligente : Telefono
    {
        //propiedades de un telefono inteligente 
        public String SistemaOperativo { get; set; }

        public int MemoriaRam { get; set; } //En Gb

        /*metodo en el cual se ingresaran todos los 
           datos de telefono inteligente*/
        public void RegistrarInteligente()
        {
            Console.Write("  Por favor ingrese la marca: ");
            this.Marca = Console.ReadLine();
            Console.WriteLine("");

            Console.Write(" Por favor ingrese el modelo: ");
            this.Modelo = Console.ReadLine();
            Console.WriteLine("");

            Console.Write(" Por favor ingrese el precio: ");
            this.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Por favor ingrese el stock: ");
            this.Stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Por favor ingrese el sistema operativo: ");
            this.SistemaOperativo = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Por favor ingrese la memoria RAM en GB: ");
            this.MemoriaRam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        }

        public void MostrarInformacionInteligente()
        {
            this.MostrarInformacion();
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}, Memoria RAM: {MemoriaRam} GB");
          
        }


    }

}
