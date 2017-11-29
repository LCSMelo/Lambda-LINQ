using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] valores = { 15, 19, 58, 97, 13, 40, 86};
            
            // Func<double, double, double> calculo = (x,y) => x*y;            
            
            // Console.WriteLine(calculo(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
            
            // List<string> cidades = new List<string>();
            // cidades.Add("Campinas");
            // cidades.Add("Guarulhos");
            // cidades.Add("Salvador");
            // cidades.Add("Belo Horizonte");

            // var cid = cidades.Where(x => x. Length < 5);
            // foreach(string c in cid)
            // Console.WriteLine(c);

            // List<Alunos> aluno = new List<Alunos>(){
            //     new Alunos{Id = 10, Nome = "Pedro", Email = "pedro@terra.com.br", Idade = 35},
            //     new Alunos{Id = 11, Nome = "Helena", Email = "helena@uol.com.br", Idade = 24},
            //     new Alunos{Id = 58, Nome = "Tadeu", Email = "tadeu@terra.com.br", Idade = 35},
            //     new Alunos{Id = 7, Nome = "Vanessa", Email = "vanessa@gmail.com", Idade = 15},

            // };

            // var resultado = from a in aluno where a.Idade > 20 && a.Idade<40 select a;
            // foreach(Alunos al in resultado)
            // Console.WriteLine(al.Id + " - " + al.Nome + " - " + al.Email + " - " + al.Idade);
            
            // "a" é uma variável (pode ser qualquer uma)
            // var resultado = from a in aluno where a.Email.Contains("terra") select a;
            // foreach(Alunos al in resultado)
            //     Console.WriteLine(al.Id + " - " + al.Nome + " - " + al.Email + " - " + al.Idade);

            // var resultado = aluno.Count(x => x.Email.Contains("terra));
            // Console.Writeline(resultado);

            // var resultado = from b in aluno where
            // b.Email.Contains("terra") orderby b.Id descending select b;
            // foreach(Alunos al in resultado)
            //     Console.WriteLine(al.Id + " - " + al.Nome + " - " + al.Email + " - " + al.Idade);

            // var alu = aluno.Count(x => x.Email.Contains("@"));
            // Console.WriteLine(alu);

            // Console.ReadKey();

        ///////////////////////

            List<Produto> Prod = new List<Produto>(){
                new Produto{IdProduto = 1, NomeProduto = "Lápis", Preco = 2, IdFornecedor = 30},
                new Produto{IdProduto = 2, NomeProduto = "Borracha", Preco = 5, IdFornecedor = 41},
                new Produto{IdProduto = 3, NomeProduto = "Caneta", Preco = 6, IdFornecedor = 30},
                new Produto{IdProduto = 4, NomeProduto = "Caderno", Preco = 20, IdFornecedor = 41},
            };
            
            List<Fornecedor> Forne = new List<Fornecedor>(){
                new Fornecedor{IdFornecedor = 30, RazaoSocial = "Faber Castel", Telefone = "11"},
                new Fornecedor{IdFornecedor = 41, RazaoSocial = "Bic", Telefone = "56"},
                new Fornecedor{IdFornecedor = 51, RazaoSocial = "Chameco", Telefone = "45"},
            };

                var resultado = Prod.Join(
                    Forne, 
                    p => p.IdFornecedor, 
                    f => f.IdFornecedor, 
                    (p,f) => new {
                        pNome = p.NomeProduto,
                        fRazao = f.RazaoSocial
                    });

                foreach(var x in resultado)
                System.Console.WriteLine("Produto: " + x.pNome + "\nFornecedor: " + x.fRazao);

                Console.ReadKey();

        }
    }    
}