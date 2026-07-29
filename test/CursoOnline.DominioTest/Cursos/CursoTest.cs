using ExpectedObjects;
using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTest
    {
        [Fact]
        public void DeveCriarCurso()
        {
            //Arrange
            var objetoEsperado = new
            {
                Nome = "Engenharia da Computação",
                CargaHoraria = (double)800,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)895
            };

            //Act
            var curso = new Curso(objetoEsperado.Nome, objetoEsperado.CargaHoraria, objetoEsperado.PublicoAlvo, objetoEsperado.Valor);

            //Assert
            objetoEsperado.ToExpectedObject().ShouldMatch(curso);
        }

        [Fact]
        public void NaoDeveCriarCursoComNomeVazio()
        {
            //Arrange
            var objetoEsperado = new
            {
                Nome = "Engenharia da Computação",
                CargaHoraria = (double)800,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)895
            };

            //Act e Assert
            Assert.Throws<ArgumentException>(() => new Curso(string.Empty, objetoEsperado.CargaHoraria, objetoEsperado.PublicoAlvo, objetoEsperado.Valor));
        }

        [Fact]
        public void NaoDeveCriarCursoComNomeNulo()
        {
            //Arrange
            var objetoEsperado = new
            {
                Nome = "Engenharia da Computação",
                CargaHoraria = (double)800,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)895
            };

            //Act e Assert
            Assert.Throws<ArgumentException>(() => new Curso(null, objetoEsperado.CargaHoraria, objetoEsperado.PublicoAlvo, objetoEsperado.Valor));
        }

        public enum PublicoAlvo
        {
            Estudante, 
            Universitário, 
            Empregado,
            Empreendedor
        }

        public class Curso
        {
            public string Nome { get; private set; }
            public double CargaHoraria { get; private set; }
            public PublicoAlvo PublicoAlvo { get; private set; }
            public double Valor { get; private set; }

            public Curso(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, double valor)
            {
                if (nome == string.Empty)
                {
                    throw new ArgumentException();
                }

                if (nome == null)
                {
                    throw new ArgumentException();
                }

                Nome = nome;
                CargaHoraria = cargaHoraria;
                PublicoAlvo = publicoAlvo;
                Valor = valor;
            }
        }
    }
}
