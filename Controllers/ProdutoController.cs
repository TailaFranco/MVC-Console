using System.Collections.Generic;
using MVC.Models;
using MVC.View;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
        public void MostrarProdutos()
        {
            List<Produto> todos = produto.Ler(); 
            produtoView.ListarTodos(todos); 
        }
    }
}