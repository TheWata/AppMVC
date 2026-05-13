using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
//Utilizando o SQLite para criar a tabela de pessoas

namespace AppMVC.Models
{

    public class Pessoa
    {
        [PrimaryKey, AutoIncrement] 
        public int Id { get; set; } //chave primáriac para o SQLite
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string DirImagem { get; set; }
        public DateTime DataCriacao = DateTime.Now;


    }
}
