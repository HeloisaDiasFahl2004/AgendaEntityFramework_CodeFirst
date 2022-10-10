using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaEntityFramework_CodeFirst.Model
{
    internal class Person 
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public string Mail { get; set; }

        public override string ToString()
        {
            return "\nId: " + this.Id + "\nNome: " + this.Name + "\nTelefone: " + this.Phone+"\nEmail: "+this.Mail;
        }
    }
}
