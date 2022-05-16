using eJogos.Interface;
using System.Collections.Generic;
using System.IO;

namespace eJogos.Models
{

    //Herança
    public class Equipe : EquipeBase, IEquipe
    {

        //Get e set significa o que vamos fazer com as propriedades
        //Get - pegar
        //Set - 
        public int idEquipe { get; set; }
        public string nome { get; set; }

        public string imagem { get; set; }

        //Variavel de Dados

        private const string caminhobd = "Database/equipe.csv";

        public Equipe()
        {
            //metodo da classe de herança equipeBase.
            CriarPastaouArquivo(caminhobd);
        }

        //Criar Função que vai receber o objeto Equipe,
        //e vai retornar no formato de csv. (string)

        private string Preparar(Equipe e)
        {
            //return e.idEquipe + ";" + e.nome + ";" + e.imagem;

            return $"{ e.idEquipe};{ e.nome};{ e.imagem}";
            
        }

        public void Criar(Equipe novaEquipe)
        {
            string valor = Preparar(novaEquipe);
            //array de string = na posição 0 temos o retorno do "Preparar"
            string[] equipe_texto = {valor};

            //arquivo vamos adicionar uma nova linha 
            //caminho do arquivo, string em formato de array.
            File.AppendAllLines(caminhobd, equipe_texto);
        }
        public List<Equipe> LerEquipes()
        {
            List<Equipe> listaEquipes = new List<Equipe>();

            //Ler todas as linhas do arquivo vcs e armazenar num array.
            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                // 1;nome da equipe;caminho

                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.nome = linhaEquipe[1];
                equipeAtual.imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);
            }
            return listaEquipes;
        }
    }
}
