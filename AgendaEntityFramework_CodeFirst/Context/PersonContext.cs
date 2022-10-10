using AgendaEntityFramework_CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaEntityFramework_CodeFirst.Context
{
    //faz a referencia de banco de dados pra poder criar a tabela
    internal class PersonContext: DbContext //classe do EF referenciada para o EF compreender que a classe person vai se tornar uma tabela
    {
        public DbSet<Person> Persons { get; set; }//função chamada Persons que cria a tabela com os atributos da classe Person
    }
}
