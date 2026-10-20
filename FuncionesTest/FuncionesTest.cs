using ActividadTDDAppAnGoGa2627;

namespace FuncionesTest
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void CalcularFactorial_NumeroNegativo()
        {
            long resultado = Funciones.calcularFactorialAnGoGa2627(-3);
            Assert.AreEqual(-1,resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cero()
        {
            long resultado = Funciones.calcularFactorialAnGoGa2627(0);
            Assert.AreEqual(1,resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Uno()
        {
            long resultado = Funciones.calcularFactorialAnGoGa2627(1);
            Assert.AreEqual(1,resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cinco()
        {
            long resultado = Funciones.calcularFactorialAnGoGa2627(5);
            Assert.AreEqual(120,resultado);
        }
    }
}
