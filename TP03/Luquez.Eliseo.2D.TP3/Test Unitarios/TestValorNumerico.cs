using System;
using EntidadesAbstractas;
using EntidadesInstanciadas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitarios
{
    [TestClass]
    public class TestValorNumerico
    {
        [TestMethod]
        public void TestMethodValorNumerico()
        {
            string dni = "12234458";
            Alumno a1 = new Alumno(2, "Juana", "Martinez", dni, Persona.ENacionalidad.Argentino,
                    Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.Deudor);

            Assert.AreEqual(int.Parse(dni), a1.DNI);
        }
    }
}
