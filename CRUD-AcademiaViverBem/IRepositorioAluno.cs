using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_AcademiaViverBem
{
    public interface IRepositorioAluno<T>
    {
        List<T> Lista();
        T RetornaPorIndice(int indice);//CONFIRMAR ESTA PARTE
        void Insere(T entidade);
        void Exclui(int indice);//CONFIRMA ESTA PARTE
        void Atualiza(int indice, T entidade);//CONFIRMA ESTA PARTE
        int ProximoIndice();//CONFIRMA ESTA PARTE
    }
}

