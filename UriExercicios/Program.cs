﻿using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = ("T");

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            Console.WriteLine("teste do git");

            Console.WriteLine("ola teste para voltar no commit");
            Console.WriteLine("não deu certo da outra vez");
            Console.WriteLine("não deu certo da outra vez");
            Console.WriteLine("não deu certo da outra vez");
            Console.WriteLine("não deu certo da outra vez");

        }
    }
}



