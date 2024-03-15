using System;

namespace Datos
{
    public class AuditoriaUsuarios
    {
        public int IDAuditoria { get; set; }
        public string Operacion { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string CampoAfectado { get; set; }
        public string DatoAnterior { get; set; }
        public string NuevoDato { get; set; }
    }
}