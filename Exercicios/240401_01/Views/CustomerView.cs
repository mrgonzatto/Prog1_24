using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Controllers;

namespace _240401_01.Views
{
    public class CustomerView
    {
        private CustomerController customerController;
        private AddressView addressView;

        public CustomerView()
        {
            addressView = new AddressView();
            customerController = new CustomerController();
            this.Init();
        }
        
        public void Init()
        {
            Console.WriteLine("MENU CUSTOMER");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Consumidor");
                Console.WriteLine("2 - Pesquisar Consumidor");
                Console.WriteLine("3 - Listar Consumidores");
                Console.WriteLine("4 - Exportar dados delimitados");
                Console.WriteLine("5 - Importar dados delimitados");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                        break;
                        case 1:
                            InsertCustomer();
                        break;
                        case 2:
                            SearchCustomer();
                        break;
                        case 3: 
                            ListCustomers();
                        break;
                        case 4:
                        {
                            if(customerController.ExportToDelimited())
                            {
                                Console.WriteLine("Arquivo gerado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Falha ao gerar arquivo.");
                            }
                        }
                        break;

                        case 5:
                            ImportFromDelimited();
                        break;

                        default: 
                            Console.WriteLine("Opção inválida.");
                            aux = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Opção inválida.");
                    menu = -1;
                }                
            }while(aux);
        }

        private void ImportFromDelimited()
        {
            Console.WriteLine("Informe o caminho do arquivo:");
            string pathFile = Console.ReadLine();

            Console.WriteLine("Informe o caracter delimitador:");
            string delimiter = Console.ReadLine();
            
            string response = 
            customerController
            .ImportFromDelimited(pathFile, delimiter);

            Console.WriteLine(response);
        }

        private void InsertCustomer()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("***********************");

            Customer customer = new Customer();
            
            Console.Write("Nome:");
            customer.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Email:");
            customer.EmailAddress = Console.ReadLine();
            Console.WriteLine("");
            
            int aux = 0;
            do{
                Console.WriteLine("Deseja informar endereço?");
                Console.WriteLine("0 - Não");
                Console.WriteLine("1 - Sim");
                try
                {
                    aux = Convert.ToInt32(Console.ReadLine());
                    if(aux == 1)
                    {
                        customer.Addresses.Add(addressView.Insert());
                    }
                    else if( aux == 0 )
                    {
                        break;
                    }
                    else
                    {
                        aux = 1;
                        Console.WriteLine("Opção inválida.");
                        Console.WriteLine("Tente novamente.");                        
                    }
                }  
                catch(Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    aux = 1;
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Tente novamente.");
                }              
            }while(aux != 0);

            try{
                customerController.Insert(customer);
                Console.WriteLine("Customer inserido com sucesso!");
            }catch{
                Console.WriteLine("Ops! Ocorreu um erro.");
            }

        }

        private void SearchCustomer()
        {    
            int aux = -1;
            do
            {
                Console.WriteLine("PESQUISAR CLIENTE");
                Console.WriteLine("*****************");
                Console.WriteLine("1 - Buscar por Id");
                Console.WriteLine("2 - Buscar por nome");
                Console.WriteLine("0 - Sair");   

                string menuOpt = Console.ReadLine();
                aux = Convert.ToInt16(menuOpt);
                switch(aux)
                {
                    case 1:
                        Console.WriteLine("Informe o id:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        ShowCustomerById(id);
                    break;
                    case 2:
                        Console.WriteLine("Informe o nome:");
                        string name = Console.ReadLine();
                        ShowCustomersByName(name);
                    break;

                    case 0:
                    break;

                    default: 
                        aux = -1;
                        Console.WriteLine("Opção inválida!");
                    break;
                }                         
            } while(aux != 0);            
        }

        private void ShowCustomerById(int id)
        {            
            Customer? c = customerController.Get(id);

            if(c != null)
            {
                Console.WriteLine(c.ToString());
            }
            else
            {
                Console.WriteLine($"Consumidor de id {id} não encontrado!");
            }
        }

        private void ShowCustomersByName(string name)
        {
            List<Customer> result = customerController.GetByName(name);

            if( (result == null || result?.Count == 0 ))
            {
                Console.WriteLine("Não encontrado!");
                return;                
            }

            foreach(Customer customer in result)
            {
                Console.WriteLine(customer.ToString());
            }
        }

        private void ListCustomers()
        {
            List<Customer> result = customerController.Get();

            if( (result == null || result?.Count == 0 ))
            {
                Console.WriteLine("Não encontrado!");
                return;                
            }

            foreach(Customer customer in result)
            {
                Console.WriteLine(customer.ToString());
            }            
        }
    }
}