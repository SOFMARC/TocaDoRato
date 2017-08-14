using ProjLoja.Domain.Entities;
using ProjLoja.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLoja.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPornome(string nome)
        {
            return Db.Produtos.Where(p => p.Descricao == nome);
        }
    }
}
