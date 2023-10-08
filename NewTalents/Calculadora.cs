using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> historico;
        private DateTime data;

        public Calculadora(DateTime data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            historico.Insert(0, $"Resultado: {resultado} - {data}");
            return resultado;

            //return num1 + num2;
        }

        public int Subtrair( int num1 , int num2 )
        {
            int resultado = num1 - num2;
            historico.Insert(0 , $"Resultado: {resultado} - {data}");
            return resultado;

        }

        public int Multiplicar( int num1 , int num2 )
        {
            int resultado = num1 * num2;
            historico.Insert(0 , $"Resultado: {resultado} - {data}");
            return resultado;
        }

        public int Dividir( int num1 , int num2 )
        {
            int resultado = num1 / num2;
            historico.Insert(0 , $"Resultado: {resultado} - {data}");
            return resultado;
        }

        public List<string> Historico()
        {
            List<string> res;
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}
