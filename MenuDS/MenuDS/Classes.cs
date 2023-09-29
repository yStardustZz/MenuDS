using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDS
{
    class Classes
    {
        public class Getset
        {
            public decimal _num1;
            public decimal _num2;

            public decimal Num1
            {
                get => _num1;
                set => _num1 = value;
            }
            public decimal Num2
            {
                get => _num2;
                set => _num2 = value;
            }

            public string Potenciacao(decimal a, decimal b)
            {
                return Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)).ToString();
            }

            public string Par_e_Impar()
            {
                string resposta;

                if (Num1 % 2 == 0 && Num2 % 2 == 0)
                {
                    resposta = $"{Num1} e {Num2} são Pares".ToString();
                }
                else if (Num1 % 2 == 1 && Num2 % 2 == 0)
                {

                    resposta = $"{Num1} é Impar e {Num2} é Par".ToString();
                }
                else if (Num1 % 2 == 0 && Num2 % 2 == 1)
                {

                    resposta = $"{Num1} é Par e {Num2} é Impar".ToString();
                }
                else
                {
                    resposta = $"{Num1} e {Num2} são Impares".ToString();
                }

                return (resposta);
            }

            public string Comparar()
            {
                string resposta;

                if (Num1 > Num2)
                {
                    resposta = $"{Num1} é maior que {Num2}".ToString();
                }
                else if (Num1 < Num2)
                {
                    resposta = $"{Num1} é menor que {Num2}".ToString();
                }
                else
                {
                    resposta = $"{Num1} é igual a {Num2}".ToString();
                }

                return (resposta);
            }


        }
    }
}

