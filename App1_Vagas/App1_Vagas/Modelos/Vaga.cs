using System;
using System.Collections.Generic;
using System.Text;
using SQLite;



namespace App1_Vagas.Modelos
{
    // Data Notations
    [Table("Vaga")]
    public class Vaga
    {
        [PrimaryKey, AutoIncrement]
        public int Id { set; get; } 
        public string NomeVaga { set; get;  }
        public short Quantidade { set; get; }
        public string Empresa { set; get; }
        public string Cidade { set; get; }
        public double Salario  { set; get; }
        public string Descricao { set; get; }
        public string TipoContratacao { set; get; }
        public string Telefone { set; get; }
        public string Email { set; get; }

    }
}
