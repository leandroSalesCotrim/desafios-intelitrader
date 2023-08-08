using System.Linq.Expressions;
using System.Numerics;
using System.Text;

namespace Desafios;

public class Desafio3
{
    public static void desafio()
    {
        Console.WriteLine("Desafio 3: Codificando um arquivo para base 64 e decodificando");

        Console.WriteLine("OBS: optei por deixar o caminho utilizando por padrão o arquivo.txt que criei para este projeto para deixar mais facil de executar");

        //definindo caminho do diretório até o arquivo.txt
        String caminho = "./arquivo.txt";

        int escolha = 0;
        while (escolha != 3)
        {
            Console.WriteLine("Escolha uma das opções abaixo\n1-Codificar o arquivo.txt\n2-decodificar o arquivo.txt\n3-Finalizar aplicação");
            escolha = int.Parse(Console.ReadLine());
            String arquivoConteudo = System.IO.File.ReadAllText(caminho);


            //validando se o arquivo existe no caminho indicado
            if (File.Exists(caminho))
            {
                byte[] arquivo = System.IO.File.ReadAllBytes(caminho);
                if (escolha == 1)
                {
                    //Lendo conteudo do arquivo e convertendo para base64
                    String arquivoCodificado = Convert.ToBase64String(arquivo);

                    //Alterando conteudo do arquivo para o base64 
                    File.WriteAllText(caminho, arquivoCodificado);

                    System.Console.WriteLine("arquivo.txt codificado para base64: " + arquivoCodificado);
                }
                else if (escolha == 2)
                {
                    //Convertendo o conteudo que esta em base64 para a forma original em bytes e exibindo no formato utf8
                    byte[] arquivoEmBytes = Convert.FromBase64String(arquivoConteudo);
                    String arquivoDecodificado = System.Text.Encoding.UTF8.GetString(arquivoEmBytes);

                    //Restaurando conteudo do arquivo para o conteudo original 
                    File.WriteAllText(caminho, arquivoDecodificado);
                    System.Console.WriteLine("arquivo.txt decodificado de base64 para a forma original: " + arquivoDecodificado);
                }
                else
                {
                    Console.WriteLine("Escolha uma opção valida");
                }
            }
            else
            {
                System.Console.WriteLine("Arquivo não encontrado, verifique se o arquivo.txt esta presente no diretorio do projeto");
            }
        }


    }
}
