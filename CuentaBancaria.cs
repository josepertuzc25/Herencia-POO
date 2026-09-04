public class CuentaBancaria
{
    public string Titular {get; set;}
    public string NumeroCuenta {get; set;}

    protected decimal Saldo;

    public CuentaBancaria(
        string titular,
        string numeroCuenta,
        decimal saldoInicial)
    {
        Titular = titular;
        NumeroCuenta = numeroCuenta;
        Saldo = saldoInicial;
    }
    public void Depositar(decimal cantidad)
    {
        bool validacion = Validar(cantidad);
        if(validacion)
        {
            Saldo += cantidad;
            Console.WriteLine("Operacion exitosa");
        }
    }


    public virtual void MostrarInformacion ()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Cuenta: {NumeroCuenta}");
        Console.WriteLine($"Saldo: {Saldo}");
    }

    private bool Validar(decimal cantidad)
    {
        if (cantidad <= 0)
        {
            Console.WriteLine("Valor incorrecto");
            return false;
        }
        return true;
    }
}