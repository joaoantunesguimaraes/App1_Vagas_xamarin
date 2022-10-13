using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using App1_Vagas.Banco;
using Xamarin.Forms;
using System.IO;
using App1_Vagas.iOS.Banco;

[assembly:Dependency(typeof(App1_Vagas.iOS.Banco.Caminho))]
namespace App1_Vagas.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            // Directoria Ficheiros pessoais
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhoDaBiblioteca = System.IO.Path.Combine(caminhoDaPasta, "..", "Library");

            // path + ficheiro da Base de Dados
            string caminhoBanco = System.IO.Path.Combine(caminhoDaBiblioteca, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}