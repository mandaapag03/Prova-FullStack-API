using Microsoft.EntityFrameworkCore;
using ProvaApi.Data;
using ProvaApi.Model;
using ProvaApi.Model.Interface;
using VerifyNullablesObjects;

namespace ProvaApi.Repository{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DatabaseContext _context;

        public PedidoRepository()
        {
            _context = new DatabaseContext();   
        }

        public Pedido Create(Pedido pedido)
        {
            try
            {
                _context.Pedidos.Add(pedido);
                _context.SaveChanges();
                var lastId = _context.Pedidos.Max(x => x.Id);
                return GetPedido(lastId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Pedido> GetAll()
        {
            return _context.Pedidos.AsNoTracking().ToList();
        }

        public Pedido GetPedido(int id)
        {
            return NullOrEmptyVariable<Pedido>.ThrowIfNull(
                _context.Pedidos.FirstOrDefault(p => p.Id == id),
                "Pedido não encontrado"
            );
        }
    }
}