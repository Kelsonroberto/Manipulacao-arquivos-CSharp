using System;
using manipularArquivo.manipularArquivos;
using System.IO;

namespace manipularArquivo{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Users\\kelso\\Manipular arquivos";

            //Combina o caminho que é passado por parâmetro e adiciona nomes para a novas pastas e subpastas os novos diretórios
            var caminhoPathDirectory = Path.Combine(caminho, "Pasta teste 2", "subpasta2");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-de-Stream-texto.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-de-texto.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-de-texto-backup.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 2", "arquivo-de-Stream-texto.txt");
            
            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            fileHelper helper = new fileHelper();
            //helper.ListarDiretorio(caminho);

            //helper.ListarArquivosDiretorios(caminho);
            
            //helper.CriarDiretorio(caminhoPathDirectory);
            
            //helper.ApagarDiretorio(caminhoPathDirectory, true);

            //helper.CriarArquivoTexto(caminhoArquivo, "OK, O teste foi concluído com sucesso!!");

            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
           // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);

           //helper.LerArquivoStream(caminhoArquivo);

           //helper.MoverAquivo(caminhoArquivo, novoCaminhoArquivo, false);
           //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

           //helper.DeletarArquivo(caminhoArquivoTesteCopia);
        }
    }
}
