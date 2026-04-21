using Clases;
namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMotorolaPerdidaBateria()
        {
            Motorola moto = new Motorola();
            
            Usuario motoUsuario = new Usuario(moto);
            Usuario motoUsuario2 = new Usuario(moto);

            motoUsuario.Llamar(motoUsuario2, 100);
            
            double puntajeEsperado = 4.75;

            Assert.AreEqual(puntajeEsperado, motoUsuario.TotalBateria());
        }
    }
}