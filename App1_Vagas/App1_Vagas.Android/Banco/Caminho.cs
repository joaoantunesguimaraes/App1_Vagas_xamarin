using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using App1_Vagas.Banco;
using System.IO;
using App1_Vagas.Droid.Banco;

[assembly:Dependency(typeof(App1_Vagas.Droid.Banco.Caminho))]
namespace App1_Vagas.Droid.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            // Directoria Ficheiros pessoais
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            // path + ficheiro da Base de Dados
            string caminhoBanco = System.IO.Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}