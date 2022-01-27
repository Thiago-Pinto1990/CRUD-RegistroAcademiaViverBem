using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_AcademiaViverBem
{
    public class Aluno : Base
    {
        private double mensalidade;//ATRIBUTO ESPECÍFICO DE ALUNO

        public double Mensalidade
        {
            get { return mensalidade; }
            set { mensalidade = value; }
        }

        //CRIANDO CONSTRUTOR
        public Aluno(string nome=null,string matricula=null, Modalidade modalidade = 0, string dataNascimento=null,string dataEntrada=null,double mensalidade=0)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            
            this.DataNascimento = dataNascimento;
            this.DataEntrada = dataEntrada;
            this.Modalidade = modalidade;
            this.Mensalidade = mensalidade;
            this.Excluido = false;
        }

        //SOBRESCREVENDO O MÉTODO ToString
        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Matricula: " + this.Matricula + Environment.NewLine;
            
            retorno += "Data de Nascimento: " + this.DataNascimento + Environment.NewLine;
            retorno += "Data de Entrada: " + this.DataEntrada + Environment.NewLine;
            retorno += "Modalidade: " + this.Modalidade + Environment.NewLine;
            retorno += "Mensalidade: " + this.Mensalidade + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        /*LEMBRAR: 
         Está herdando os métodos: RetornaNome , RetornaMatricula , Exclui e RetornaExcluido
        */


    }
}
