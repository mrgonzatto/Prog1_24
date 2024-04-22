using _240325_01.Models;

// Primeira Clinica
Clinica c1 = new Clinica();
Clinica.InstanceCount = 1;
c1.ObjectCount = 1;

// Segunda Clinica
Clinica c2 = new Clinica();
Clinica.InstanceCount++;
c2.ObjectCount = 10;

Console.WriteLine(
    $"Valor C1: {c1.ObjectCount}"
);
Console.WriteLine(
$"Instance Count: {Clinica.InstanceCount}"
);
Console.WriteLine(
    $"Valor C2: {c2.ObjectCount}"
);