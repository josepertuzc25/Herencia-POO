public class CuentaCorriente : CuentaBancaria
{
    public decimal LimiteSobregiro { get; set; }

    public CuentaCorriente(
        string titular,
        string numeroCuenta,
        decimal saldoInicial,
        decimal limiteSobregiro)
        : base(titular, numeroCuenta, saldoInicial)
    {
        LimiteSobregiro = limiteSobregiro;
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad <= 0)
        {
            Console.WriteLine("Valor a retirar incorrecto");
        }
        else if (cantidad <= Saldo + LimiteSobregiro)
        {
            Saldo -= cantidad;
            Console.WriteLine($"Retiro realizado: ${cantidad}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes");
        }
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Límite de sobregiro: ${LimiteSobregiro}");
    }
}