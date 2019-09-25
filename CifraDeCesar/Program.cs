using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifraDeCesar
{
    class Program
    {
        //Marlon Raoni Siqueira Ramos 
        static void Main(string[] args)
        {
            int escolha = 0;

            while (escolha != 3)
            {
                string txt1 = "", txt2 = "";
                int num = 0;
                Console.WriteLine("Digite 1 para criptografar!");
                Console.WriteLine("Digite 2 para descriptografar!");
                Console.WriteLine("Digite 3 para encerrar a aplicação!");
                escolha = Convert.ToInt16(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Digite o texto que deseja criptografar!");
                        txt1 = Console.ReadLine();
                        for (int i = 0; i < txt1.Length; i++)
                        {
                            if (txt1[i] == 'x')
                            {
                                txt2 += 'a';
                            }
                            else if (txt1[i] == 'y')
                            {
                                txt2 += 'b';
                            }
                            else if (txt1[i] == 'z')
                            {
                                txt2 += 'c';
                            }
                            else
                            {
                                num = Convert.ToInt16(txt1[i]) + 3;
                                txt2 += Convert.ToChar(num);
                            }
                        }
                        Console.WriteLine("Texto criptografado --> {0}", txt2);
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        Console.WriteLine("Digite o texto que deseja descriptografar!");
                        txt1 = Console.ReadLine();
                        for (int i = 0; i < txt1.Length; i++)
                        {
                            if (txt1[i] == 'a')
                            {
                                txt2 += 'x';
                            }
                            else if (txt1[i] == 'b')
                            {
                                txt2 += 'y';
                            }
                            else if (txt1[i] == 'c')
                            {
                                txt2 += 'z';
                            }
                            else
                            {
                                num = Convert.ToInt16(txt1[i]) - 3;
                                txt2 += Convert.ToChar(num);
                            }
                        }
                        Console.WriteLine("Texto descriptografado --> {0}", txt2);
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n");
                        break;

                }
            }
        }
    }
}

