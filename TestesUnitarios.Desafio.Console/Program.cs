// See https://aka.ms/new-console-template for more information
using TestesUnitarios.Desafio.Console.Services;

Console.WriteLine("Hello, World!");
var valida = new ValidacoesLista();
Console.WriteLine(valida.MultiplicarNumerosLista(new List<int> { 5, 7, 8, 9 }, 2));