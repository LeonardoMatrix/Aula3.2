using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;

namespace ControleBicicleta
{
    class Program

   

    {
        static List<Bicicleta> lista = new List<Bicicleta>();

        static void Main(string[] args)
        {




            Bicicleta bicicleta; 
            Fabricante fabricante;
            Cargo cargo; 
            string status;
            status = "N";

            do
            {

                if (status != "L") {

                    bicicleta = new Bicicleta();
                    fabricante = new Fabricante();
                    cargo = new Cargo();


                    Console.WriteLine("Informe o Id");
                bicicleta.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe o Modelo");
                bicicleta.Modelo = (Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe a Data");
                bicicleta.DataFabricacao = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe o Id do fabricante");
                fabricante.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe o Nome do fabricante");
                fabricante.Nome = (Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe o Id do cargo");
                cargo.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe o Nome do cargo");
                cargo.Descricao = (Console.ReadLine());
                Console.WriteLine("\n");

                    fabricante.Cargo = cargo;
                    bicicleta.Fabricante = fabricante;
                

                lista.Add(bicicleta);

                Console.WriteLine(bicicleta.ToString());

                }
                else
                {

                    Console.WriteLine("Listando: \n");

                    foreach (Bicicleta  b in lista)
                    {

                        Console.WriteLine(b.ToString());
                        Console.WriteLine("\n");

                    }




                }

                Console.WriteLine("\n");
                Console.WriteLine("Deseja criar registro ?");
                Console.WriteLine("S-SIM / N-NÃO / L-Listar");
                status = (Console.ReadLine());


            } while (status == "S" || status == "L");


        }
    }
}
