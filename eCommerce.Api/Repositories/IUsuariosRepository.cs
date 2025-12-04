using eCommerce.Api.Models;

namespace eCommerce.Api.Repositories
{
    public interface IUsuariosRepository
    {
        public List<Usuario> Get();

        public Usuario Get(int Id);

        public void Insert(Usuario usuario);

        public void Update(Usuario usuario);

        public void Delete(int id);
    }
}
