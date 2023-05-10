﻿Console.WriteLine("Hola, escribe tu nombre");
var nombre = Console.ReadLine();
Console.Write("Adiós ");
for (int i = (nombre.Length-1); i >= 0; i--)
{
    Console.Write(nombre[i]);
}