using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProjectTest
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string data;

        public Calculadora(string data)
        {
            ListaHistorico = new List<string>();
           this.data = data;
        }

        public int Somar(int a, int b)
        {
            int soma = a + b;
            ListaHistorico.Insert(0, "Resultado: "+soma+ " - data: "+ data);
            return soma;
        }

        public int Subtracao(int a, int b)
        {
            int soma = a - b;
            ListaHistorico.Insert(0, "Resultado: " + soma + " - data: " + data);
            return soma;
        }

        public int Multiplicacao(int a, int b)
        {
            int soma = a * b;
            ListaHistorico.Insert(0, "Resultado: " + soma + " - data: " + data);
            return soma;
        }

        public int Dividir(int a, int b) 
        {
            int soma = a / b;
            ListaHistorico.Insert(0, "Resultado: " + soma + " - data: " + data);
            return soma;
        }

        public List<string> Historico()
        {
            return ListaHistorico.Take(3).ToList();
        }

    }
}
