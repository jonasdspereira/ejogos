using System.IO;

namespace eJogos.Models
{
    //Funções utilizadas pelo programa
    public class EquipeBase
    {
        public void CriarPastaouArquivo(string caminho)
        {
            //"nome pasta /nome do arquivo.csv"

            string pasta = caminho.Split('/')[0];


            //Se o diretorio não existir, criar pasta.
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(caminho);
            }
            //Se o arquivo não existir, criar aquivo.
            if (!File.Exists(pasta))
            {
                File.Create(caminho);
            }
        }




    }
}
