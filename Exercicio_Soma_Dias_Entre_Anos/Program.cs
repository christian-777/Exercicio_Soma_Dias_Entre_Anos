internal class Program
{
    private static void Main(string[] args)
    {
        //exercicio soma dias anos

        int anoInicio;
        int anoFim;

        int soma=0;

        Console.WriteLine("digite o ano de inicio: ");
        anoInicio = int.Parse(Console.ReadLine());

        Console.WriteLine("digite o ano de termino: ");
        anoFim = int.Parse(Console.ReadLine());

        if (anoFim > anoInicio)
        {

            for (int i = anoInicio; i <= anoFim; i++)
            {
                if(i%100==0)
                {
                    if(i%400==0 && i%4==0)
                    {
                        soma += 366;
                        Console.WriteLine(i + " ano bisexto");
                    }
                    else
                    {
                        soma += 365;
                        Console.WriteLine(i + " ano nao bisexto");
                    }
                }
                else
                {
                    if(i%4==0)
                    {
                        soma += 366;
                        Console.WriteLine(i + " ano bisexto");
                    }
                    else
                    {
                        soma += 365;
                        Console.WriteLine(i + " ano nao bisexto");
                    }
                }
                if (i % 4 == 0 || (i % 100 != 0 && i % 400 == 0))
                {
                    soma += 366;
                    Console.WriteLine(i + " ano bisexto");
                }
                else
                {
                    soma += 365;
                    Console.WriteLine(i + " ano nao bisexto");
                }
            }
        } 
        Console.WriteLine("soma: "+soma);
    }
}