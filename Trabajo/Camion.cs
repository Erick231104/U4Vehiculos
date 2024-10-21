using System;
public class Camion : Vehiculo
{
    public double CapacidadCarga { get;  }
    public Camion(string marca, string modelo, double capacidadCarga) : base(marca, modelo)
    {
        CapacidadCarga = capacidadCarga;
    }

    public override void Moverse()
    {
        Console.WriteLine($"{Marca} {Modelo} se esta moveindo el camon con capacidad de {CapacidadCarga} toneladas.");
    }

    public override string ToString()
    {
        return base.ToString() + $"la marca es: {Marca}, ell modelo es: {Modelo}, su capacidad de carga es de: {CapacidadCarga} en toneladas";
    }
}
