using BlazorAppSistemaVendaBCC.Entities;

namespace BlazorAppSistemaVendaBCC.Service.Interface
{
    public interface IProdutoService
    {
        Task AdicionarAsync(Produto Produto);
        Task AlterarAsync(Produto Produto);
        Task ExcluirAsync(int id);

        Task<IEnumerable<Produto>> ListarTodos();
        Task<Produto> PesquisarPorId(int id);
    }
}
