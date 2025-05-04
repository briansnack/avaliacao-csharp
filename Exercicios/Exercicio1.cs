using System;
using System.Text.RegularExpressions;

class Exercicio1
{
    public static void Rodar()  // Alterado para um método sem ponto de entrada
    {
        Console.Write("Digite uma senha: ");
        string? senha = Console.ReadLine();

        if (string.IsNullOrEmpty(senha))
        {
            Console.WriteLine("Senha inválida. Ela não pode ser nula ou vazia.");
            return;
        }

        bool temTamanho = senha.Length >= 8;
        bool temMaiuscula = Regex.IsMatch(senha, "[A-Z]");
        bool temNumero = Regex.IsMatch(senha, "[0-9]");
        bool temEspecial = Regex.IsMatch(senha, "[!@#\\$%\\^&\\*]");

        if (temTamanho && temMaiuscula && temNumero && temEspecial)
        {
            Console.WriteLine("Senha válida!");
        }
        else
        {
            Console.WriteLine("Senha inválida. Ela deve conter ao menos 8 caracteres, uma letra maiúscula, um número e um caractere especial.");
        }
    }
}