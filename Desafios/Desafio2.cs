using System;

public class Desafio2
{
    public static void desafio()
    {
        Console.WriteLine("Desafio 2: Aplicação que criptografa/descriptografa arquivos utilizando Cifra de César.");

        Console.WriteLine("OBS: optei por deixar o caminho utilizando por padrão o arquivo.txt que criei para este projeto para deixar mais facil de executar");

        //definindo caminho do diretório até o arquivo.txt
        String caminho = "./arquivo.txt";

        int escolha = 0, deslocamento = 3;
        while (escolha != 3)
        {
            Console.WriteLine("Escolha uma das opções abaixo\n1-criptografar o arquivo.txt\n2-descriptografar o arquivo.txt\n3-Finalizar aplicação");
            escolha = int.Parse(Console.ReadLine());
            string arquivoCifrado = "";
            string arquivoDecifrado = "";


            //validando se o arquivo existe no caminho indicado
            if (File.Exists(caminho))
            {
                String arquivoConteudo = System.IO.File.ReadAllText(caminho);

                if (escolha == 1)
                {
                    for (int i = 0; i < arquivoConteudo.Length; i++)
                    {
                        //validando se o caracter atual é uma letra para evitar tentar criptografar caracteres especiais
                        if (char.IsLetter(arquivoConteudo[i]))
                        {
                            //resgatando o valor numero do caracter e somando + o deslocamento para criptografar
                            int numeroCaracter = Convert.ToInt16(char.ToUpper(arquivoConteudo[i])) + deslocamento;

                            //Validando caso o caracter passe do limite alfabetico, por exemplo: yxz passam do limite
                            //com o deslocamento igual a 3, se tornando caracteres especiais e quebrando a cifra
                            if (numeroCaracter > 90)
                            {
                                numeroCaracter -= 26;
                            }


                            //Convertendo o numero do caracter para o char correspondente, já criptografado
                            char caracterCifrado = Convert.ToChar(numeroCaracter);

                            //somando o conteudo criptografado
                            arquivoCifrado += caracterCifrado;

                        }
                        else
                        {
                            //incluindo caracter caso ele não seja uma letra
                            arquivoCifrado += arquivoConteudo[i];
                        }

                    }
                    //substituindo o conteudo original pelo criptografado
                    File.WriteAllText(caminho, arquivoCifrado);
                    Console.WriteLine("Arquivo codificado na cifra de Cesar com sucesso!");
                }
                else if (escolha == 2)
                {
                    for (int i = 0; i < arquivoConteudo.Length; i++)
                    {
                        //validando se o caracter atual é uma letra para evitar tentar criptografar caracteres especiais
                        if (char.IsLetter(arquivoConteudo[i]))
                        {
                            //resgatando o valor numero do caracter e somando + o deslocamento para criptografar
                            int numeroCaracter = Convert.ToInt16(char.ToUpper(arquivoConteudo[i])) - deslocamento;


                            //Validando caso o caracter passe do limite alfabetico, por exemplo: yxz passam do limite
                            //com o deslocamento igual a 3, se tornando caracteres especiais e quebrando a cifra
                            if (numeroCaracter < 65)
                            {
                                numeroCaracter += 26;
                            }

                            //Convertendo o numero do caracter para o char correspondente, já criptografado
                            char caracterDecifrado = Convert.ToChar(numeroCaracter);

                            //somando o conteudo criptografado
                            arquivoDecifrado += caracterDecifrado;

                        }
                        else
                        {
                            //incluindo caracter caso ele não seja uma letra
                            arquivoDecifrado += arquivoConteudo[i];
                        }

                    }
                    //substituindo o conteudo original pelo criptografado
                    File.WriteAllText(caminho, arquivoDecifrado);
                    Console.WriteLine("Arquivo decodificado na cifra de Cesar com sucesso!");

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
