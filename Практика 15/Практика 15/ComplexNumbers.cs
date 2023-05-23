using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_15
{
    class ComplexNumbers
    {
        //Действительная часть
        public double Vaild { get; set; }
        //Мнимая часть
        public double Imaginary { get; set; }

        //public ComplexNumbers(double vaild, double imaginary)
        //{
        //    this.vaild = vaild;
        //    this.imaginary = imaginary;
        //}
        public ComplexNumbers(double vaild, double imaginary)
        {
            Vaild = vaild;
            Imaginary = imaginary;
        }
        //Сумма
        public string Sum(ComplexNumbers a)
        {
            double vaild = Vaild + a.Vaild ;
            double imaginary = Imaginary + a.Imaginary;
            return $"{Math.Round(vaild), 2} + {Math.Round(imaginary, 2)}i";
        }
        //Разность
        public string Dif(ComplexNumbers a)
        {
            double vaild = Vaild - a.Vaild;
            double imaginary = Imaginary - a.Imaginary;
            return $"{Math.Round(vaild),2} - {Math.Round(imaginary, 2)}i";
        }
        //Умножение
        public string Mul(ComplexNumbers a)
        {
            double vaild = Vaild * a.Vaild - Imaginary * a.Imaginary;
            double imaginary = Vaild * a.Imaginary + Imaginary * a.Vaild;
            return $"{Math.Round(vaild),2} * {Math.Round(imaginary, 2)}i";
        }

    }
}
