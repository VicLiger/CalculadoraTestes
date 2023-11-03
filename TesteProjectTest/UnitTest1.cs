using NewProjectTest;
using System.Security.AccessControl;
using Xunit;

namespace TesteProjectTest
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora("02/02/2020");

            return calc;
        }


        [Theory]
        [InlineData(1, 2, 3)]
        public void TestarSomar(int a, int b, int result)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.Somar(a, b);

            Assert.Equal(result, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(2, 2, 0)]
        public void TestarSubtrair(int a, int b, int result) 
        {
            Calculadora calc = construirClasse();

            int resultadoSubtracao = calc.Subtracao(a, b);

            Assert.Equal(resultadoSubtracao, result);
        }


        [Theory]
        [InlineData(2,2,4)]
        [InlineData(2,4,8)]
        public void TestarMultiplicacao(int a, int b, int result)
        {
            Calculadora calc = construirClasse();

            int resultadoMultiplicacao = calc.Multiplicacao(a, b);

            Assert.Equal(resultadoMultiplicacao, result);
        }

        [Fact]
        public void TestarDivisao()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(2, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(5, 6);
            calc.Somar(7, 8);
            calc.Somar(3, 2);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}