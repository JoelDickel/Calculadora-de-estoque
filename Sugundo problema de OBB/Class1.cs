using System;
using System.Globalization;

namespace Sugundo_problema_de_OBB
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidades;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidades;

        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidades += quantidade;
        }

        public void RemoverProdutos(int quantidadeR)
        {
            Quantidades -= quantidadeR;
        }


        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidades + " unidades, Total: $ " 
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
