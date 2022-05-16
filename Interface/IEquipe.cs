using eJogos.Models;
using System.Collections.Generic;

namespace eJogos.Interface
{
    public interface IEquipe
    {
        //Contrato
        //Representa os metodos que são obrigatório em uma classe.

        void Criar(Equipe novaEquipe);

        List<Equipe> LerEquipes();




    }
}
