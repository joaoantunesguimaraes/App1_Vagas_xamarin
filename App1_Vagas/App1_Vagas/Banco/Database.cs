using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

//using System.Linq; // ToList()

using App1_Vagas.Modelos;
using Xamarin.Forms;


namespace App1_Vagas.Banco
{
    class Database
    {
        // Variável de Instância / Propriedade
        private SQLiteConnection _conexao;

        // Construtor
        public Database()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");

            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<Vaga>();


        }

        // Métodos

        public List<Vaga> Consultar()
        {
            // pegar todas as Informações da Tablela 
            return _conexao.Table<Vaga>().ToList();
        }


        public List<Vaga> Pesquisar(string palavra)
        {
            // pegar todas as Informações da Tablela filtrada por  LIKE %palavra%
            return _conexao.Table<Vaga>().Where(pNome => pNome.NomeVaga.Contains(palavra)).ToList();
        }


        public Vaga ObterVagaPorId(int id)
        {
            // pegamos no Primeiro ou no por omissão
            //var col = from pId in _conexao.Table<Vaga>()
            //          where pId.Id == id
            //          select pId;
            //return col.FirstOrDefault();

            // Sintaxe Lambda
            return _conexao.Table<Vaga>().Where(pId=>pId.Id == id).FirstOrDefault();
        }


        public void Cadastro(Vaga vaga)
        {
            _conexao.Insert(vaga);
        }

        public void Atualizacao(Vaga vaga)
        {
            _conexao.Update(vaga);
        }

        // ? Não é necessário passar o Id ??
        public void Exclusao(Vaga vaga)
        {
            _conexao.Delete(vaga);
        }



    }
}
