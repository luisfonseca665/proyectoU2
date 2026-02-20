namespace proyectoU2.Backend
{

    /// <summary>
    /// Clase Refacciones que representa las refacciones en el sistema de gestión de la mecánica. Contiene propiedades para almacenar información relevante sobre cada refacción, como su código, nombre, marca, precio unitario, stock actual, stock mínimo y proveedor.
    /// </summary>
    public class Refacciones
    {
        public string codigo_refaccion { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public decimal precio_unitario { get; set; }
        public int stock_actual { get; set; }
        public int stock_minimo { get; set; }
        public string proveedor { get; set; }
    }
}