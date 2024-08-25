using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacionPractica
{
    //Crear la clase FiguraGeometrica

    public class FiguraGeometrica
    {
        public string Nombre { get; set; }

        public FiguraGeometrica(string nombre)
        {
            Nombre = nombre;
        }
    }

     //Crear la interface Poligono con el siguiente método:
     //public double area(double valor1, double valor2)

    public interface Poligono
    {
        double Area(double valor1, double valor2);
    }

    //Crear las clases (que heredan de FiguraGeometrica e implementan Poligono):
    //Triángulo, Rectangulo y Paralelogramo(con sus atributos pertinentes y método
    //ToString() que retorne un texto mostrando el nombre y su área calculada)

    public class Triangulo : FiguraGeometrica, Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(string nombre, double baseTriangulo, double altura) : base(nombre) {

            this.Base = baseTriangulo;
            this.Altura = altura;
        }

        public double Area(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        public override string ToString()
        {
            
            return $" Nombre: {Nombre} \n Área: {Area(this.Base,this.Altura)}";
        }
    }

    public class Rectangulo : FiguraGeometrica, Poligono
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(string nombre, double largo,double ancho) : base(nombre) {
        
            this.Largo = largo;
            this.Ancho = ancho;
        }

        public double Area(double largo, double ancho)
        {
            return largo * ancho;
        }

        public override string ToString()
        {
            return $" Nombre: {Nombre} \n Área: {Area(this.Largo, this.Ancho)}";
        }
    }

    public class Paralelogramo : FiguraGeometrica, Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Paralelogramo(string nombre, double baseparalelogramo, double altura) : base(nombre) { 
        
            this.Base = baseparalelogramo;
            this.Altura = altura;
        }

        public double Area(double baseParalelogramo, double altura)
        {
            return baseParalelogramo * altura;
        }

        public override string ToString()
        {
            return $" Nombre: {Nombre} \n Área: {Area(this.Base, this.Altura)}";
        }
    }

}
