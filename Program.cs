﻿﻿double altura, PesoIdeal;
string sexo;

Console.Write("Digite a sua respectiva altura em Metros: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Sexo Masculino = [M] / Feminino = [F]: ");
sexo = Console.ReadLine()!.ToUpper().Trim();

if (sexo != "M" && sexo != "F")
{
    Console.WriteLine("Não possuo fórmula para cálculo");
}
else
{
    if (sexo == "M")
    {
        PesoIdeal = altura * 72.7 - 58.0;
    }
    else
    {
        PesoIdeal = altura * 62.1 - 44.7;
    }

    Console.WriteLine($"Seu peso ideal é {PesoIdeal:N1}kg.");

}

