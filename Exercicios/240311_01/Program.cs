// OPERADORES
int a = 3;
int b = a++; // ++ é um acumulador
// Neste ++ vai somar a + 1
// Entretando o acúmulo vai ocorrer depois da 
// atribuição pois o ++ está do lado direito de a
WriteLine($"a é {a}, b é {b}");
//-----------------
int c = 3;
int d = ++c;
WriteLine($"c é {c}, d é {d}");
// Neste caso o ++ está do lado esquerdo de c,
// Portado o acúmulo ocorre antes da atribuição
//---------------
//Combinando operadores de atribuição
int p = 6;
p += 3; //Equivalente a p = p + 3;
p -= 3; //Equivalente a p = p - 3;
p *= 3; //Equivalente a p = p * 3;
p /= 3; //Equivalente a p = p / 3;

// OPERADORES LÓGICOS
bool b_A = true;
bool b_B = false;
WriteLine($"AND  | b_A   | b_B  ");
WriteLine($"b_A  | {b_A & b_A, -5} | {b_A & b_B, -5}");
WriteLine($"b_B  | {b_B & b_A, -5} | {b_B & b_B, -5}");
WriteLine();
WriteLine($"OR   | b_A   | b_B  ");
WriteLine($"b_A  | {b_A | b_A, -5} | {b_A | b_B, -5}");
WriteLine($"b_B  | {b_B | b_A, -5} | {b_B | b_B, -5}");
WriteLine();
WriteLine($"XOR  | b_A   | b_B  ");
WriteLine($"b_A  | {b_A ^ b_A, -5} | {b_A ^ b_B, -5}");
WriteLine($"b_B  | {b_B ^ b_A, -5} | {b_B ^ b_B, -5}");