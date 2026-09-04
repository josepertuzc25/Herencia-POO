public class CuentaAhorros : CuentaBancaria
{
    public decimal TasaInteres {get; set;}

    public CuentaAhorros(string titular, 
    string numeroCuenta,
    decimal saldoInicial,
    decimal tasaInteres) : base(titular,numeroCuenta,saldoInicial)
    {
        TasaInteres = tasaInteres;
    }
    public void AplicarInteres()
    {
        decimal interes = Saldo * (TasaInteres/100);
        Saldo += interes
    }
    public override void MostrarInformacion ()
    {
        base.MostrarInformacion
        Console.WriteLine($"Tasa Intere:{TasaInteres}";)
    }
}