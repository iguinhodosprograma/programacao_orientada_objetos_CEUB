namespace BlazorVendas.Model
{
    public class ItemVenda
    {
        public Int32 ProdutoId { get; set; }
        public Int32 VendaId { get; set; }
        public Int32 QuantidadeProduto { get; set; }
        public double PrecoUnitario { get; set; }

        public void IserirItem()
        {
            //Inserir
        }
        public void ExcluirItem()
        {
            //Excluir
        }
    }
}
