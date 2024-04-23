using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240318_01.Models
{
    public class Customer
    {
        // Definição de Atributos
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress {get; set;} 

        //public Address Address1 {get;set;}       
        //public Address Address2 {get;set;}

        // Atributo para Lista de endereços
        public List<Address> Addresses = 
            new List<Address>();


        // Métodos
        public bool Validate()
        {
            return true;
        }
    }
}