namespace ConsoleApp1.Services
{
    /// <summary>
    /// Representa un cóctel con su nombre, ingredientes e instrucciones.
    /// </summary>
    public class CocktailDto
    {
        /// <summary>
        /// Obtiene o establece el nombre del cóctel.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Obtiene o establece la lista de ingredientes del cóctel.
        /// </summary>
        public List<string>? Ingredients { get; set; }

        /// <summary>
        /// Obtiene o establece las instrucciones para preparar el cóctel.
        /// </summary>
        public string? Instructions { get; set; }
    }
}
