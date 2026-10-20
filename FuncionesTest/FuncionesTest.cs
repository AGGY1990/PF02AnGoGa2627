using ActividadTDDAppAnGoGa2627;

namespace FuncionesTest
{
    [TestClass]
    public sealed class FuncionesTest
    {
        //---------Función calcularFactorial--------
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


        //------------Función esContrasenyaValida---------------
        [TestMethod]
        public void EsContrasenyaValida_Null()
        {
            bool resultado = Funciones.EsContrasenyaValidaAnGoGa2627(null);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_Vacia()
        {
            bool resultado = Funciones.EsContrasenyaValidaAnGoGa2627("");
            Assert.IsFalse(resultado);
        }

        //
        [TestMethod]
        public void EsContrasenyaValida_MenorDeOchoCaracteres()
        {
            bool resultado = Funciones.EsContrasenyaValidaAnGoGa2627("abc#123");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_Valida()
        {
            bool resultado = Funciones.EsContrasenyaValidaAnGoGa2627("abc#1234");
            Assert.IsTrue(resultado);
        }

    }
}
