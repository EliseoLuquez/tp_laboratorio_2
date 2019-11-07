using System;
using EntidadesAbstractas;
using EntidadesInstanciadas;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitarios
{
    [TestClass]
    public class TestDniInvalidoException
    {
        [TestMethod][ExpectedException(typeof(DniInvalidoException))]
        public void TestMethodDniInvalidoException()
        {
            Alumno a3 = new Alumno(3, "Esteban", "Quito", "a4372657", Persona.ENacionalidad.Argentino,
                Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
      
        }
    }
}
