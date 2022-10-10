using AgendaEntityFramework_CodeFirst.Context;
using AgendaEntityFramework_CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaEntityFramework_CodeFirst
{
    internal class Program//todas as classes são internal agora
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())//criei o objeto
            {
                #region Insert
                context.Persons.Add(new Person() { Name = "Heloísa", Phone = "16992863582", Mail = "helofahl@gmail.com" });//inseri o registro no banco
                context.SaveChanges();//comando de executar, exceto na hora de remover

                Person p = new Person();
                p.Name = "Roberta";
                p.Phone = "16999999999";
                p.Mail = "rofahl@gmail.com";
                context.Persons.Add(p);
                context.SaveChanges();
                #endregion

                #region Select All
                var persons = new PersonContext().Persons.ToList();
                foreach (var item in persons)
                {
                    Console.WriteLine(item.ToString());
                }
                #endregion

                #region Select One
                Console.Write("Informe o nome da pessoa que deseja buscar: ");
                string n = Console.ReadLine();
                Person find = new PersonContext().Persons.FirstOrDefault(f => f.Name == n);
                if (find != null)
                {
                    Console.WriteLine(find.ToString());
                }
                else
                {
                    Console.WriteLine("Registro não encontrado!");
                }
                #endregion

                #region Delet
                context.Entry(find).State = EntityState.Deleted;//entry é tipo um select, altera o estado para deleted
                context.Persons.Remove(find);//para remover os registros é necessário alterar o estados para deleted (a função remove exige um estado alterado)
                context.SaveChanges();//aqui executa realmente 
                #endregion

                #region Update

                #endregion
                Console.ReadKey();
            }
        }
    }
}
