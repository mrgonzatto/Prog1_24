using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Repository;
using _240401_01.Models;

namespace _240401_01.Controllers
{
    public class AddressController
    {
        private AddressRepository addressRepository;

        public AddressController()
        {
            addressRepository = new AddressRepository();
        }

        public Address Insert(Address address)
        {            
            addressRepository.Create(address);
            return address;
        }

        public Address Get(int id)
        {
            return addressRepository.Read(id);
        }

        public List<Address> Get()
        {
            return addressRepository.Read();
        }        
    }
}