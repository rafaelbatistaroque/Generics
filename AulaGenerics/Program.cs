using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTreinaWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Pessoa pessoa = new Pessoa(1, nome);

            ClsGeneric<Pessoa> repositorio = new ClsGeneric<Pessoa>();
            repositorio.InsertList(pessoa);

            foreach (Pessoa p in repositorio.GetList())
            {
                Console.WriteLine("id nr: {0} | Nome: {1}", p.Id, p.Nome);
            }
        }
    }
}
