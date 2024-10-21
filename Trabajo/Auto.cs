using System;
public class Auto : Vehiculo
{

    public Auto(string marca, string modelo) : base(marca, modelo) { }
    public override void Moverse()
    {
        Console.WriteLine($"{Marca} {Modelo} se esta moviendo el auto");
    }
}

