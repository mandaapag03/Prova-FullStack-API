using Microsoft.AspNetCore.Mvc;
using ProvaApi.Model;
using ProvaApi.Repository;

namespace ProvaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{

    private readonly ILogger<PedidoController> _logger;
    private readonly PedidoRepository _pedidoRepository;

    public PedidoController(ILogger<PedidoController> logger)
    {
        _logger = logger;
        _pedidoRepository = new PedidoRepository();
    }

    [HttpGet]
    public ActionResult<Pedido[]> GetAll()
    {
        try
        {
            return Ok(_pedidoRepository.GetAll());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public ActionResult<Pedido> Get(int id)
    {
        try
        {
            return Ok(_pedidoRepository.GetPedido(id));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("criar")]
    public ActionResult<Pedido> CreatePedido([FromBody] Pedido pedido)
    {
        try
        {
            return Ok(_pedidoRepository.Create(pedido));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
