using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_AcademiaViverBem
{
    public class Professor : Base
    {
        private double salario;//ATRIBUTO EXCLUSIVO DE PROFESSOR

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        //CRIANDO CONSTRUTOR
        public Professor(string nome = null, string matricula = null, string dataNascimento = null, string dataEntrada = null, Modalidade modalidade = 0, double salario = 0)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.DataNascimento = dataNascimento;
            this.DataEntrada = dataEntrada;
            this.Modalidade = modalidade;
            this.Salario = salario;
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
            retorno += "Salário: " + this.Salario + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;
        }


    }
}
