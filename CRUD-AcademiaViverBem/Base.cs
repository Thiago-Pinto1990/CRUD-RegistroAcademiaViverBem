using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_AcademiaViverBem
{
    public abstract class Base//CRIADO APENAS PARA SER HERDADO POR ALUNO E PROFESSOR, NÃO PODE SER INSTANCIADO
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string DataNascimento { get; set; }
        public string DataEntrada { get; set; }
        public Modalidade Modalidade { get; set; }
        public bool Excluido { get; set; }

        public string RetornaNome()//MÉTODO SERÁ USADO NO MÉTODO LISTAR() NA CLASSE PROGRAM
        {
            return this.Nome;
        }

        public string RetornaMatricula()//MÉTODO SERÁ USADO NO MÉTODO LISTAR() NA CLASSE PROGRAM
        {
            return this.Matricula;
        }

        public void Exclui()//MÉTODO SERÁ USADO PARA MARCAR OBJETO COMO EXCLUÍDO
        {
            this.Excluido = true;
        }

        public bool RetornaExcluido()//MÉTODO SERÁ USADO PARA RETORNAR A MARCAÇÃO ANTERIOR
        {
            return this.Excluido;
        }


    }
}
