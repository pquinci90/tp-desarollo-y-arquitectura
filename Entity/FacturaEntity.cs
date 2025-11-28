using Entity.DbModels;

namespace Entity
{
    public class FacturaEntity
    {
        public int Id { get; set; }

        public string Metodo { get; set; } = null!;

        public double Monto { get; set; }

        public DateTime Fecha { get; set; }

        public  bool Aprobado { get; set; }

        public UsuarioEntity Usuario { get; set; }
    }
}
