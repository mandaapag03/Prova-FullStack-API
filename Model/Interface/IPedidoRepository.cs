namespace ProvaApi.Model.Interface
{
    public interface IPedidoRepository{
        List<Pedido> GetAll();
        Pedido GetPedido(int id);
        Pedido Create(Pedido pedido);
    }
}