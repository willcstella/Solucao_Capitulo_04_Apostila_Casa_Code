using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;


namespace PersistenceProject
{
    public class Repository
    {
        //fornecedores

        public IList<Fornecedor> fornecedores = new List<Fornecedor>();
        public IList<Produto> produtos = new List<Produto>();
        public IList<NotaEntrada> notasEntrada = new List<NotaEntrada>();

        public Fornecedor InsertFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Add(fornecedor);
            return fornecedor;
        }
        public void RemoveFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Remove(fornecedor);
        }
        public IList<Fornecedor> GetAllFornecedores()
        {
            return this.fornecedores;
        }
        public Fornecedor UpdateFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores[this.fornecedores.IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }

        // ---- fim fornecedores ----

        // produto

        public Produto InsertProduto(Produto produto)
        {
            this.produtos.Add(produto);
            return produto;
        }

        public void RemoveProduto(Produto produto)
        {
            this.produtos.Remove(produto);
        }

        public IList<Produto> GetAllProduto()
        {
            return this.produtos;
        }

        public Produto UpdateProduto(Produto produto)
        {
            this.produtos[this.produtos.IndexOf(produto)] = produto;
            return produto;
        }

        // ---- fim produto

        // nota de entrada

        public NotaEntrada InsertNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notasEntrada.Add(notaEntrada);
            return notaEntrada;
        }

        public void RemoveNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notasEntrada.Remove(notaEntrada);
        }

        public IList<NotaEntrada> GetAllNotaEntrada()
        {
            return this.notasEntrada;
        }

        public NotaEntrada UpdateNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notasEntrada[this.notasEntrada.IndexOf(notaEntrada)] = notaEntrada;
            return notaEntrada;
        }

        // ---- fim nota de entrada
    }
}
