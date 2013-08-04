using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thunderbird.Factory.Entity;
using Thunderbird.Business.Implementation;
using System.Collections.Generic;

namespace Alunos.Business.Teste
{
    [TestClass]
    public class AlunoTeste
    {
        [TestMethod]
        public void cadastrar()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Aluno 3";
            //aluno.Ativo = true;

            AlunoRepository _repository = new AlunoRepository();
            _repository.Salvar(aluno);
        }


        [TestMethod]
        public void cadastrarSemestre()
        {
            Semestre s = new Semestre();
            s.Ano = "2013";
            s.NomeSemestre = "2";
            //aluno.Ativo = true;

            SemestreRepository _repository = new SemestreRepository();
            _repository.Salvar(s);
        }

        [TestMethod]
        public void alterar()
        {
            Aluno aluno = new Aluno();
            aluno.Codigo = 1;
            aluno.Nome = "Aluno 1";

            AlunoRepository _repository = new AlunoRepository();
            _repository.Alterar(aluno);
        }

        [TestMethod]
        public void deletar()
        {
            Aluno aluno = new Aluno();
            aluno.Codigo = 4;

            AlunoRepository _repository = new AlunoRepository();
            _repository.Excluir(aluno);
        }

        [TestMethod]
        public void selecionarTodos()
        {
            AlunoRepository _repository = new AlunoRepository();
            IList<Aluno> fromDB = _repository.ObterTodos();
            Assert.IsNotNull(fromDB);

            foreach (Aluno _atual in fromDB)
            {
                Console.WriteLine(_atual.Codigo);
                Console.WriteLine(_atual.Nome);
                Console.WriteLine("--------------------------------");
            }
        }

        [TestMethod]
        public void selecionarCodigo()
        {
            AlunoRepository _repository = new AlunoRepository();
            Aluno fromDB = _repository.ObterPorId(1);
            Assert.IsNotNull(fromDB);

            Console.WriteLine(fromDB.Nome);
        }

        [TestMethod]
        public void selecionarTodosSemestre()
        {
            SemestreRepository _repository = new SemestreRepository();
            IList<Semestre> fromDB = _repository.ObterTodos();
            Assert.IsNotNull(fromDB);

        }

    }
}



