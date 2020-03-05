using ResourceAccess.Cultura;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Pruebas prueba = new Pruebas();
            string resultado;

            resultado = await prueba.ConsumoService();

            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        public class Pruebas
        {
            public async Task<string> ConsumoService()
            {
                CulturaResourceAccess cultura = new CulturaResourceAccess();
                var result = await cultura.GetMuseosAsync();
                return result.results[1].nombre;
            }
        }
        
    }
}
