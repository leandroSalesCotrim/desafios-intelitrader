using System.Numerics;

namespace Desafios
{
    public class Desafio6
    {
        public static void desafio()
        {
            Console.WriteLine("Desafio 6: Imprimindo a multiplicação dos 2 números digitados");

            //Solicitando os valores e guardando em string para poder converter mais tarde
            //OBS: estou utilizando string pois desta forma o usuário consegue digitar o numero completo
            //sem ser interpretado como um numero Integer
            
            System.Console.WriteLine("Insira o primeiro valor:");
            string valorInserido1 = Console.ReadLine();

            System.Console.WriteLine("Insira o segundo valor:");
            string valorInserido2 = Console.ReadLine();

            //validando se o número é um big integer valido
            if (BigInteger.TryParse(valorInserido1, out BigInteger bigInt1) && BigInteger.TryParse(valorInserido2, out BigInteger bigInt2))
            {
                //convertendo as string para big integer
                BigInteger valor1 = BigInteger.Parse(valorInserido1);
                BigInteger valor2 = BigInteger.Parse(valorInserido2);

                //imprimindo valores digitados
                Console.WriteLine("Valor 1: {0}\nvalor 2: {1}", valor1, valor2);

                //Imprimindo a multiplicação
                Console.WriteLine("Resultado: " + valor1 * valor2);

            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar um número válido.");
            }

        }
    }
}