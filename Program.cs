// Entrada

Console.WriteLine($"Digite a nota do primeiro aluno");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a nota do segundo aluno");
float nota2 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a nota do terceiro aluno");
float nota3 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a nota do quarto aluno");
float nota4 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a nota do quinto aluno");
float nota5 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
Console.WriteLine($"sua media é:{media}");

