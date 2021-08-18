using Xunit;

namespace DomainTest
{
    public class TesteXunit
    {
        [Fact(DisplayName = "IgualdadeVariaveis")]
        public void VariaveisDevemTerMesmoValor()
        {
            //AAA
            //Organizaçãp
            var number1 = 2;
            var number2 = 1;

            //Ação
            number1 = number2;

            //Assert
            Assert.Equal(number1, number2);
        }
    }
}