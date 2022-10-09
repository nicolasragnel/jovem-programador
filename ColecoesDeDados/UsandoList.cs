using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ColecoesDeDados
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}. Preço: R${Preco}";
        }
    }

    public class CarrinhoComprasArray
    {
        private int _IndiceAtual = 0;
        private Produto[] _ProdutosNoCarrinho;

        public CarrinhoComprasArray()
        {
            _ProdutosNoCarrinho = new Produto[10];
        }

        private void AumentarCarrinho(int qtd = 10)
        {
            var auxArray = new Produto[_ProdutosNoCarrinho.Length + qtd];

            for (int i = 0; i < _ProdutosNoCarrinho.Length; i++)
            {
                auxArray[i] = _ProdutosNoCarrinho[i];
            }

            _ProdutosNoCarrinho = auxArray;
        }

        public void AdicionarProduto(Produto produto)
        {
            if (_IndiceAtual + 1 == _ProdutosNoCarrinho.Length)
            {
                AumentarCarrinho();
            }

            _ProdutosNoCarrinho[_IndiceAtual] = produto;
            _IndiceAtual++;
        }
    }

    public class CarrinhoComprasList
    {
        private List<Produto> _ProdutosNoCarrinho;

        public CarrinhoComprasList()
        {
            _ProdutosNoCarrinho = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            _ProdutosNoCarrinho.Add(produto);
        }
    }

    internal class UsandoList
    {
        public static void Executar()
        {
            List<string> listaString = new List<string>();
            listaString.Add("Bryan");

            List<string> listaString2 = new List<string>()
            {
                "Marco",
                "Denis",
                "Marcos",
                "Caio",
            };

            listaString.AddRange(listaString2);
            Console.WriteLine($"A lista possui {listaString.Count} itens que são: {string.Join(',', listaString)}");
            listaString.RemoveAt(0);
            Console.WriteLine($"A lista possui {listaString.Count} itens que são: {string.Join(',', listaString)}");

            foreach(var valor in listaString)
            {
                Console.WriteLine(valor);
            }

            #region Diferença comportamento List x Array
            //var sb = new StringBuilder();
            //var carrinho = new CarrinhoComprasArray();
            ////carrinho = new CarrinhoComprasList();

            //for (int i = 0; i < 100; i++)
            //{
            //    var produto = new Produto($"Nome_{i}", Math.Pow(2, i));
            //    sb.AppendLine(produto.ToString());
            //    carrinho.AdicionarProduto(produto);
            //}

            //Console.WriteLine(sb.ToString());
            #endregion
        }
    }
}
