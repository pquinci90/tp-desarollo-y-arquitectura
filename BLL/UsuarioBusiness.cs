using DAL;
using Entity;
using System.Transactions;
using Utils;

namespace BLL
{
    public class UsuarioBusiness
    {
        private UsuarioData usuarioData = new();
        public UsuarioEntity Login(string usuario, string contraseña)
        {
            try
            {
                var userFind = GetByUsuario(usuario);

                if (userFind == null)
                {
                    throw new Exception("Usuario no encontrado");
                }
                if (userFind.Usuario == usuario && (HashUtil.VerifyPassword(contraseña, userFind.Contraseña)))
                {
                    return userFind; // Autenticación exitosa
                }
                throw new Exception("Credenciales inválidas");
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al iniciar sesión: " + ex.Message);

            }
        }
        public void CrearUsuario(UsuarioEntity usuarioRegistrar)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    ValidateUser(usuarioRegistrar);
                    if (GetByUsuario(usuarioRegistrar.Usuario) != null)
                    {
                        throw new Exception("El usuario ya existe");
                    }
                    usuarioRegistrar.Contraseña = HashUtil.HashPassword(usuarioRegistrar.Contraseña);
                    usuarioData.CreateUsuario(usuarioRegistrar);
                    trx.Complete();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al crear usuario: " + ex.Message);
            }
        }
        public UsuarioEntity GetByUsuario(string usuario)
        {
            try
            {
                var userFind = usuarioData.GetUsuarioByUsername(usuario);
                if (userFind != null)
                {
                    return userFind;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al verificar existencia de usuario: " + ex.Message);
            }
        }
        private void ValidateUser(UsuarioEntity usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario), "El usuario no puede ser nulo.");

            // Nombre
            if (string.IsNullOrWhiteSpace(usuario.Nombre) || usuario.Nombre.Length <= 4)
                throw new ArgumentException("El nombre debe tener más de 4 caracteres.", nameof(usuario.Nombre));

            // Apellido
            if (string.IsNullOrWhiteSpace(usuario.Apellido) || usuario.Apellido.Length <= 4)
                throw new ArgumentException("El apellido debe tener más de 4 caracteres.", nameof(usuario.Apellido));

            // Dni: cantidad de dígitos > 4
            if (usuario.Dni.ToString().Length <= 4)
                throw new ArgumentException("El DNI debe tener más de 4 dígitos.", nameof(usuario.Dni));

            // Contraseña
            if (string.IsNullOrWhiteSpace(usuario.Contraseña) || usuario.Contraseña.Length <= 4)
                throw new ArgumentException("La contraseña debe tener más de 4 caracteres.", nameof(usuario.Contraseña));

            // Usuario
            if (string.IsNullOrWhiteSpace(usuario.Usuario) || usuario.Usuario.Length <= 4)
                throw new ArgumentException("El usuario debe tener más de 4 caracteres.", nameof(usuario.Usuario));

            // Admin se ignora para la validación
        }
    }
}
