using System;
using EntidadesInstanciadas;
using Excepciones;
using EntidadesAbstractas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitarios
{
    [TestClass]
    public class TestAlumnoRepetidoException
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestMethodAlumnoRepetidoException()
        {
            Universidad uni = new Universidad();
            Alumno a1 = new Alumno(1, "Esteban", "Quito", "34372657", Persona.ENacionalidad.Argentino, 
                Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Alumno a2 = new Alumno(2, "Roman", "Riquelme", "34372657", Persona.ENacionalidad.Argentino,
                Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            uni += a1;
            uni += a2;
        }
    }
}
