using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoOnline.DominioTest
{
    public class MeuPrimeiroTeste
    {
        [Fact(DisplayName = "Apelido Teste")]
        public void DeveVariavel1SerIgualVariavel2()
        {
            //Arrange - Preparação do Cenário
            var variavel1 = 1;
            var variavel2 = 2;

            //Act - Ação
            //Exemplo
            //variavel1 = variavel2;

            //Assert - Verificação
            Assert.Equal(variavel1, variavel2);

        }
    }
}
