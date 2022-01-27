using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_AcademiaViverBem
{
    public class AlunoRepositorio : IRepositorioAluno<Aluno>
    {
        private List<Aluno> ListaAluno = new List<Aluno>();//LISTA SERÁ O BANCO DE REGISTRO

        public void Atualiza(int indice, Aluno entidade)//MÉTODO PARA ATUALIZAR REGISTRO
        {
            ListaAluno[indice] = entidade;
        }

        public void Exclui(int indice)//MÉTODO PARA MARCAR REGISTRO COMO EXCLUÍDO
        {
            ListaAluno[indice].Exclui();
        }

        public void Insere(Aluno entidade)//MÉTODO PARA INSERIR NOVO REGISTRO
        {
            ListaAluno.Add(entidade);
        }

        public List<Aluno> Lista()//MÉTODO PARA LISTAR REGISTRO
        {
            return ListaAluno;
        }

        public int ProximoIndice()//MÉTODO PARA CRIAR O ÍNDICE(ARRAY) DO REGISTRO
        {
            return ListaAluno.Count;
        }


        public Aluno RetornaPorIndice(int indice)//MÉTODO PARA RETORNA REGISTRO DE UM DETERMINADO ÍNDICE
        {
            return ListaAluno[indice];
        }

    }
}
