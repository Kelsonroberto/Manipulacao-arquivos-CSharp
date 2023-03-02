using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace manipularArquivo.manipularArquivos
{
    public class fileHelper
    {
        public void ListarDiretorio(string caminho)
        {
            //Pegar todos diretórios e suas subpastas
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            //Percorrer cada um dos diretórios do caminho e apresentá-los no Console
            foreach (var retorno in retornoCaminho){
                Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            //O segundo parâmetro em string, foi adaptado para trazer todos os arquivos com o final .txt
            var retornoArquivos = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
            {
                Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
                       
            Console.WriteLine(retorno.FullName);            
        }

        public void ApagarDiretorio(string caminho, bool deletarArquivos)
        {
            //ATENÇÃO: Um arquivo apagado não vai para a lixeira, ou seja todo arquivo será excluído permanentemente!!!!
            Directory.Delete(caminho, deletarArquivos);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            //Caso o arquivo não exista, então crie. A finalidade dessa condição é não sobrepor um arquivo já existente.
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }            
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            //recomendado para arquivos muito grandes
            using(var stream = File.CreateText(caminho)){
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
           }           
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

         public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            //Incrementa alterações sem sobrepor oque já existia
            using(var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
           }           
        }

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
               Console.WriteLine(linha);
            }
        }

        public void LerArquivoStream(string caminho)
        {
            //recomendado para arquivos muito grandes

            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                   Console.WriteLine(linha);
                   
                }
                
            }
        }

        public void MoverAquivo(string caminho, string NovoCaminho, bool sobrescrever)
        {
            //O arquivo pode ir para outro caminho com outro nome
            File.Move(caminho, NovoCaminho, sobrescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }

    }
}
