using ConsoleApp1.Db;
using ConsoleApp1.Services;

class Program
{
    static async Task Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            // 0. Crear servicio para hacer consumo de api
            var apiClient = new CocktailApiClient();

            // 1. Obtener la lista de cócteles desde la API
            List<CocktailDto>? lstCocktailDto = await apiClient.GetCocktailsAsync();

            // 2. Guardar los cócteles en la base de datos

            // 3. Consultar y mostrar los cócteles guardados
        }

        Console.ReadKey();
    }
}