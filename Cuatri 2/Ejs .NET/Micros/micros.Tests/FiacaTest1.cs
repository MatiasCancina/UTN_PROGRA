using _20260414___Clase_09.Clases;
using Xunit;

namespace micros.Tests;

public class MicroMock : Micro
{
    public MicroMock(int volumen, int cantidadAsientos, int cantidadParados)
        : base(volumen, cantidadAsientos, cantidadParados)
    {
    }
}

public class UnitTest1
{
    [Fact]
    public void FiacaSubeTest()
    {
        var fiaca = new Fiaca();
        var apurado = new Apurado();
        var micro = new Micro(200, 2, 5);
        micro.Subir(apurado);

        Assert.True(fiaca.AceptaSubir(micro));
    }

    [Fact]
    public void FiacaNoSubeTest()
    {
        var fiaca = new Fiaca();
        var apurado = new Apurado();
        var micro = new MicroMock(200, 1, 5);

        micro.Pasajeros.Add(new Apurado());

        Assert.False(fiaca.AceptaSubir(micro));
    }

}
