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
            var objetoEsperado = new
            {
                Nome = "Engenharia da Computação",
                CargaHoraria = (double) 800,
                PublicoAlvo = "Estudante",
                Valor = (double) 895
            };

            var curso = new Curso(objetoEsperado.Nome, objetoEsperado.CargaHoraria, objetoEsperado.PublicoAlvo, objetoEsperado.Valor);

            objetoEsperado.ToExpectedObject().ShouldMatch(curso);
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
