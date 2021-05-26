using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //***********************************************AULA 01 PARTE 02******************************************************************
            //ContaCorrente contaDaGabriela = new ContaCorrente();

            //contaDaGabriela.titular = "Gabriela";
            //contaDaGabriela.agencia = 863;
            //contaDaGabriela.numero = 863452;
            //contaDaGabriela.saldo = 100;

            //Console.WriteLine($"Titular : {contaDaGabriela.titular}");
            //Console.WriteLine($"Agencia :{contaDaGabriela.agencia}");
            //Console.WriteLine($"Numero :{contaDaGabriela.numero}");
            //Console.WriteLine($"Saldo :{contaDaGabriela.saldo}");


            //contaDaGabriela.saldo += 200;

            //***********************************************AULA 02 PARTE 02******************************************************************

            //ContaCorrente Conta = new ContaCorrente();

            //Conta.titular = "Gabriela";

            //Console.WriteLine(Conta.titular);
            //Console.WriteLine(Conta.saldo);

            //Console.ReadLine();

            //***********************************************AULA 03 PARTE 02******************************************************************

            //ContaCorrente contaDaGabriela = new ContaCorrente();

            //contaDaGabriela.titular = "Gabriela";
            //contaDaGabriela.agencia = 863;
            //contaDaGabriela.numero = 863452;


            //ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            //contaDaGabriela.titular = "Gabriela";
            //contaDaGabriela.agencia = 863;
            //contaDaGabriela.numero = 863452;

            //Console.ReadLine();

            //***********************************************AULA 04 PARTE 02******************************************************************

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(50);
            Console.WriteLine(contaDoBruno.saldo);


            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);




            Console.ReadLine();



        }
    }
}
