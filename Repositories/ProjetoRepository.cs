using ExoApi.Contexts;
using ExoApi.Models;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoContext _context;

        public ProjetoRepository(ExoContext context)
        {
            _context = context;
        }

        public List<Projeto> Listar() => _context.Projetos.ToList();
        public Projeto? BuscarPorId(int id) => _context.Projetos.Find(id);

        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Projeto projeto)
        {
            var p = _context.Projetos.Find(id);
            if (p != null)
            {
                p.NomeDoProjeto = projeto.NomeDoProjeto;
                p.Area = projeto.Area;
                p.Status = projeto.Status;
                _context.Projetos.Update(p);
                _context.SaveChanges();
            }
        }

        public void AtualizarParcial(int id, Projeto projeto)
        {
            var p = _context.Projetos.Find(id);
            if (p != null)
            {
                if (!string.IsNullOrEmpty(projeto.NomeDoProjeto)) p.NomeDoProjeto = projeto.NomeDoProjeto;
                if (!string.IsNullOrEmpty(projeto.Area)) p.Area = projeto.Area;
                p.Status = projeto.Status;
                _context.Projetos.Update(p);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            var p = _context.Projetos.Find(id);
            if (p != null)
            {
                _context.Projetos.Remove(p);
                _context.SaveChanges();
            }
        }
    }
}
