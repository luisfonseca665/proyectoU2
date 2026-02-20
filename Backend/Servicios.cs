namespace proyectoU2.Backend
{
    /// <summary>
    /// Clase Servicios que representa los servicios que ofrece la mecánica. Contiene propiedades para almacenar información relevante sobre cada servicio, como su clave, nombre, descripción, costo base y tiempo estimado de realización.
    /// </summary>
    public class Servicios
    {
        public int clave_servicio { get; set; }
        public string nombre_servicio { get; set; }
        public string descripcion { get; set; }
        public decimal costo_base { get; set; }
        public int tiempo_estimado { get; set; }
    }
}