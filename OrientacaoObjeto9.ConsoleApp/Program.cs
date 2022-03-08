using System;

namespace OrientacaoObjeto9.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno notas = new Aluno();
            notas.n1 = 2;
            notas.n2 = 6;
            notas.n3 = 4;
            notas.n4 = 5;

            Console.WriteLine($"A média armonica do aluno foi de: {notas.Media():F2}");
            Console.ReadKey();
        }
    }
}
