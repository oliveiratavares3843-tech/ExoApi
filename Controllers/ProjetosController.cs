using ExoApi.Models;
using ExoApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;

        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try { return Ok(_projetoRepository.Listar()); }
            catch (Exception ex) { return BadRequest(new { erro = ex.Message }); }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                var p = _projetoRepository.BuscarPorId(id);
                if (p == null) return NotFound();
                return Ok(p);
            }
            catch (Exception ex) { return BadRequest(new { erro = ex.Message }); }
        }

        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            try
            {
                _projetoRepository.Cadastrar(projeto);
                return StatusCode(201, projeto);
            }
            catch (Exception ex) { return BadRequest(new { erro = ex.Message }); }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Projeto projeto)
        {
            try
            {
                if (_projetoRepository.BuscarPorId(id) == null) return NotFound();
                _projetoRepository.Atualizar(id, projeto);
                return NoContent();
            }
            catch (Exception ex) { return BadRequest(new { erro = ex.Message }); }
        }

        [HttpPatch("{id}")]
        public IActionResult AtualizarParcial(int id, Projeto projeto)
        {
            try
            {
                if (_projetoRepository.BuscarPorId(id) == null) return NotFound();
                _projetoRepository.AtualizarParcial(id, projeto);
                return NoContent();
            }
            catch (Exception ex) { return BadRequest(new { erro = ex.Message }); }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                if (_projetoRepository.BuscarPorId(id) == null) return NotFound();
                _projetoRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception ex) { return BadRequest(new { erro = ex.Message }); }
        }
    }
}
