using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class TelefonoBasico : Telefono
    {
        //Propiedades de un telefono basico
        public bool TieneRadioFM { get; set; }

        public bool TieneLinterna { get; set; }

        /*metodo en el cual se ingresaran todos los 
         datos de telefono basico*/
        public void RegistrarBasico()
        {

            Console.Write(" Por favor ingrese la marca: ");
            this.Marca = Console.ReadLine();
            Console.WriteLine();

            Console.Write(" Por favor ingrese el modelo: ");
            this.Modelo = Console.ReadLine();
            Console.WriteLine("");

            Console.Write(" Por favor ingrese el precio: ");
             this.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            Console.Write(" Por favor ingrese el stock: ");
            this.Stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("   ¿ Tiene radio Fm ?, Si la respuesta es si, escriba (true); Si la respuesta es no, escriba (false)");
            this.TieneRadioFM = bool.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("¿ Tiene linterna, Si la respuesta es si, escriba (true); Si la respuesta es no, escriba (false)");
            this.TieneLinterna = bool.Parse(Console.ReadLine());
            Console.WriteLine("");

        }
        /*metodo que obtendra la informacions especifica */
        public void MostrarInformacionBasico()
        {

            string Tiene_RadioFM;
            string Tiene_Linterna;
            Tiene_RadioFM = (this.TieneRadioFM) ? "Si tiene radio" : "No tiene radio";

            Tiene_Linterna = (this.TieneLinterna) ? "Si tiene linterna" : "No tiene Linterna";

            this.MostrarInformacion();

            Console.WriteLine($"Tiene radio Fm: {TieneRadioFM}, Tiene Linterna: {TieneLinterna}");
        }
    }
}
  