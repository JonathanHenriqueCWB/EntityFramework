using BancoDados.Models;
using System.Linq;
namespace BancoDados.DAL
{
    class CategoriaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static Categoria BuscarCategoriaPorNome
            (Categoria c) =>
            ctx.Categorias.FirstOrDefault
            (x => x.Nome.Equals(c.Nome));
    }
}
