using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagnostica
{
    public class Variable 
    {
        private double ingreso;
        private int empleados;
        private string nombre;

        public void Pempleados(int empleados)
        {
            this.empleados = empleados;
        }
        public int Mempleados()
        {
            return this.empleados;
        }

        public void Pingresos(double ingreso)
        {
            this.ingreso = ingreso;
        }
        public double Mingresos()
        {
            return this.ingreso;
        }
        public void Pnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string Mnombre()
        {
            return this.nombre;
        }

        public double calcularInnsL(double ingreso) { return ingreso * 0.07; }
        public double calcularInnsP(double ingreso) { return ingreso * 0.021; }

    }
}
