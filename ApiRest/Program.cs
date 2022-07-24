// See https://aka.ms/new-console-template for more information
using Refit;
using System.Threading.Tasks;

namespace ApiRest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cep = RestService.For<CepInterface>("https://viacep.com.br/");
                Console.WriteLine("Digite o CEP a ser consultado: ");
                string getCep = Console.ReadLine().ToString();

                var address = await cep.GetAddressAsync(getCep);

                Console.WriteLine("logradouro: " + address.logradouro);
                Console.WriteLine("complemento: " + address.complemento);
                Console.WriteLine("bairro: " + address.bairro);
                Console.WriteLine("localidade: " + address.localidade);
                Console.WriteLine("uf: " + address.uf);
                Console.WriteLine("gia: " + address.gia);
                Console.WriteLine("ddd: " + address.ddd);
                Console.WriteLine("siafi: " + address.siafi);

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na requisição: " + e.Message);
            }
        }
    }
}
