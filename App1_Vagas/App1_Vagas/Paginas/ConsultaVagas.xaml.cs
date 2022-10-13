using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App1_Vagas.Modelos;
using App1_Vagas.Banco;


namespace App1_Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaVagas : ContentPage
    {
        public ConsultaVagas()
        {
            InitializeComponent();

            Database database = new Database();
            // Método Consultar()
            // .ItemsSource -- Itens dum ListView -- ?? 
            ListaVagas.ItemsSource = database.Consultar();
            database.Consultar();

        }

        // Método GoCadastro
        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVaga());
        }

        // Método GoMinhasVagas
        public void GoMinhasVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        // Método MaisDetalheAction
        public void MaisDetalheAction(object sender, EventArgs args)
        {
            // Parâmetro
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;
                       
            Navigation.PushAsync(new DetalheVagas(vaga));
        }



    }
}