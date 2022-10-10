using AgendaEntityFramework_CodeFirst.Context;
using AgendaEntityFramework_CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
               // context.Persons.Add(new Person() { Name = "Heloísa" , Phone="16992863582",Mail="helofahl@gmail.com"});//inseri o registro no banco
               // context.SaveChanges();//comando de executar, exceto na hora de remover

                Person p = new Person();
                p.Name = "Roberta";
                p.Phone = "16999999999";
                p.Mail = "rofahl@gmail.com";
                context.Persons.Add(p);
                context.SaveChanges();
                var persons = new PersonContext().Persons.ToList();
                foreach (var item in persons)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.ReadKey();
            }
        }
    }
}
