using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_AcademiaViverBem
{
    public class ProfessorRepositorio : IRepositórioProfessor<Professor>
    {
        private List<Professor> ListaProfessor = new List<Professor>();
        
        public void Atualiza(int indice, Professor entidade)
        {
            ListaProfessor[indice] = entidade;
        }

        public void Exclui(int indice)
        {
            ListaProfessor[indice].Exclui();
        }

        public void Insere(Professor entidade)
        {
            ListaProfessor.Add(entidade);
        }

        public List<Professor> Lista()
        {
            return ListaProfessor;
        }

        public int ProximoIndice()//USEI PARA APRESENTAR NÚMERO DO ÍNDICE
        {
            return ListaProfessor.Count;
        }

        public Professor RetornaPorIndice(int indice)
        {
            return ListaProfessor[indice];
        }

    }
}
