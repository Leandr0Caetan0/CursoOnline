using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AULA 'Domínio Curso'
namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTest_DominioCurso
    {
        [Fact]
        public void DeveCriarCurso()
        {
            const string nome = "Engenharia da Computação";
            const double cargaHoraria = 800;
            const string publicoAlvo = "Estudante";
            const double valor = 895;
            
            var curso = new Curso(nome, cargaHoraria, publicoAlvo, valor);

            Assert.Equal(nome, curso.Nome);
            Assert.Equal(cargaHoraria, curso.CargaHoraria);
            Assert.Equal(publicoAlvo, curso.PublicoAlvo);
            Assert.Equal(valor, curso.Valor);
        }

        public class Curso
        {
            public string Nome { get; private set; }
            public double CargaHoraria { get; private set; }
            public string PublicoAlvo { get; private set; }
            public double Valor { get; private set; }

            public Curso(string nome, double cargaHoraria, string publicoAlvo, double valor)
            {
                Nome = nome;
                CargaHoraria = cargaHoraria;
                PublicoAlvo = publicoAlvo;
                Valor = valor;
            }
        }
    }
}
