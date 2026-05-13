using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMVC.Models;
using AppMVC.Services;
using SQLite;
namespace AppMVC.Controllers
{
    public class PessoaController
    {
        //criar variaveis globais para uso na classe
        DatabaseService _database;
        SQLiteConnection _conexao;

        //Metodos construtores
        public PessoaController()
        {
            _database = new DatabaseService();
            _conexao = _database.GetConnection();

            _conexao.CreateTable<Pessoa>();

            //metodos de manipulação do banco
            //insert, update e delete

            
        
        }

            //insersão de um objeto por vez, 0 nenhuma linha afetada 1 uma linha afetada
        public bool AdicionarPessoa(Pessoa value) //insert
        {
            return _conexao.Insert(value)>0;
        }

            //Neste caso removeremos diretamente do banco, porém o metodo correto seria mudar uma variavel "Ativo" para false
        public bool RemoverPessoa(Pessoa value) //delete
        {
            return _conexao.Delete(value) > 0;
        }

            //Lista as pessoas 
            //select *
        public List<Pessoa> ListPessoas() { 
        return _conexao.Table<Pessoa>().ToList();
        }

        //Selecionar por id
        public Pessoa GetPessoaById(int id) {
        return _conexao.Find<Pessoa>(id) ;
        }

        public List<Pessoa> ListPessoaByName(string nome)
        {
            return _conexao.Table<Pessoa>().Where(x => x.Nome.Contains(nome)).ToList() ;  
        }

        public List<Pessoa> ListPessoaByNameQuerry(string nome)
        {
            return _conexao.Query<Pessoa>("select * from Pessoa p where p.nome = ?", nome).ToList();
        }

    }
}
