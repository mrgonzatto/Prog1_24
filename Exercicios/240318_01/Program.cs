using _240318_01.Models;

// Instância de objeto do tipo Customer
Customer c1 = new Customer();
// Atribuindo valores aos atributos do objeto c1
c1.CustomerId = 1;
c1.FirstName = "Mauricio";
c1.LastName = "Gonzatto";
c1.BirthDate = new DateTime();
c1.EmailAddress = "mauricio.gonzatto@unoesc.edu.br";

// Instância de objeto do tipo Address
Address address1 = new Address();
// Atribuindo valor aos atributos do objeto address1
address1.AddressId = 1;
address1.Street = "Augusto Benetti";
address1.District = "Santos Dumont";
address1.City = "Videira";
address1.Number = 251;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89561-160";
// AddressType é do tipo Enum - Portanto espera receber 
// valor equivalente ao seu tipo
address1.AddressType = AddressType.Commercial;

// Guardando um endereço à lista de endereços do consumidor
c1.Addresses.Add(address1);

Console.WriteLine("ENDEREÇOS:");
//
foreach(var ad in c1.Addresses)
{    
    Console.WriteLine("------------------");
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Nro: {ad.Number}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"País: {ad.Country}");
}





Console.WriteLine( $"Nome: {c1.FirstName} {c1.LastName}" );
Console.WriteLine( $"Email: {c1.EmailAddress}");
