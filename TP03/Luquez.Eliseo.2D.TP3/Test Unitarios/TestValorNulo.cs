using System;
using EntidadesAbstractas;
using EntidadesInstanciadas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitarios
{
    [TestClass]
    public class TestValorNulo
    {
        [TestMethod]
        public void TestMethodValorNulo()
        {
            Alumno a5 = new Alumno(5, "Esteban", "Quito", "34372657", Persona.ENacionalidad.Argentino,
                Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

            Assert.IsNotNull(a5.Nombre);
        }
    }
}
