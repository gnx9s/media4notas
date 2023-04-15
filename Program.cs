double grade1, grade2, grade3, grade4, media;

string resultado;

Console.WriteLine("-- Média de 4 notas --");

Console.Write("Digite a nota nº 1.... ");
grade1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite a nota nº 2.... ");
grade2 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite a nota nº 3.... ");
grade3 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite a nota nº 4.... ");
grade4 = Convert.ToDouble(Console.ReadLine());


bool gradeValid = grade1 >= 0 && grade1 <= 10 
                && grade2 >= 0 && grade2 <= 10  
                && grade3 >= 0 && grade3 <= 10  
                && grade4 >= 0 && grade4 <= 10;  


if (gradeValid)
{
    media = (grade1 + grade2 + grade3 + grade4) / 4;
    
    if (media < 5)
    {
        resultado = "Infelizmente você foi reprovado!";
    }
    
    else
    {
        if (media > 6)
        {
            resultado = "Você foi aprovado, parabéns!";
        }

        else 
        {
            resultado = "Você está de recuperação!";
        }
    }
    
    Console.WriteLine($"Sua média final é de {media:N1}. Resultado: {resultado} ");
}

else
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Digite notas presentes apenas entre 0 e 10. ");
Console.ResetColor();
}

// tadoido que demora pra fazer