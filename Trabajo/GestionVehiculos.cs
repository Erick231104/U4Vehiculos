using System;
using System.Collections.Generic;
public class GestionVehiculos
{
    private List<Vehiculo> listaVehiculos = new List<Vehiculo>();

    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        listaVehiculos.Add(vehiculo);
    }

    public List<Vehiculo> OntenerVehiculo()
    {
        return listaVehiculos;
    }
}

