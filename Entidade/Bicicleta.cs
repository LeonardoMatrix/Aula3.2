using System;

namespace Entidade
{
    public class Bicicleta
    {
        public int Id { get; set; }
        public String Modelo { get; set; }
        public Fabricante Fabricante { get; set; }
        public DateTime DataFabricacao { get; set; }


        public override string ToString()
        {

            return "Id: " + this.Id +
                    "\nModelo: " + this.Modelo +
                    "\nData: " + this.DataFabricacao +
                    "\nId Fabricante: " + this.Fabricante.Id +
                    "\nNome Fabricante: " + this.Fabricante.Nome +
                    "\nId Cargo: " + this.Fabricante.Cargo.Id +
                    "\nDescrição Cargo: " + this.Fabricante.Cargo.Descricao;

        }
    }
}
