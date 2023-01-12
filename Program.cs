using System;
using System.Runtime.ConstrainedExecution;

abstract class Barco
{
    public abstract void StartEngine();
}

class Lancha_Proa_Abierta : Barco
{
    public override void StartEngine()
    {
        Console.WriteLine("Iniciando motor de la lancha de proa abierta.");
    }
}

class Barco_Pesquero : Barco
{
    public override void StartEngine()
    {
        Console.WriteLine("Iniciando motor del barco pesquero.");
    }
}

abstract class BarcoFactory
{
    public abstract Barco CreateBarco();
}

class Lancha_Proa_AbiertaFactory : BarcoFactory
{
    public override Barco CreateBarco()
    {
        return new Lancha_Proa_Abierta();
    }
}

class Barco_PesqueroFactory : BarcoFactory
{
    public override Barco CreateBarco()
    {
        return new Barco_Pesquero();
    }
}

class Piloto
{
    static void Main(string[] args)
    {
        BarcoFactory factory = new Lancha_Proa_AbiertaFactory();
        Barco barco = factory.CreateBarco();
        barco.StartEngine();

        factory = new Barco_PesqueroFactory();
        barco = factory.CreateBarco();
        barco.StartEngine();
    }
}
