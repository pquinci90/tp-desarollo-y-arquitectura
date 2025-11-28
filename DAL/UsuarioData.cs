using DAL.Models;
using Entity;
using Mapper;

namespace DAL
{
    public class UsuarioData
    {
        public UsuarioEntity GetUsuarioByUsername(string username)
        {
            try
            {
                using var ctx = new AppDbContext();

                var usuarioDb = ctx.Usuarios.FirstOrDefault(u => u.Usuario1 == username);

                if (usuarioDb == null)
                {
                    return null;
                }
                return UsuarioMapper.ToEntity(usuarioDb);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void CreateUsuario(UsuarioEntity usuarioEntity)
        {
            try
            {
                using var ctx = new AppDbContext();
                var usuarioDb = UsuarioMapper.ToDbModel(usuarioEntity);
                ctx.Usuarios.Add(usuarioDb);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
