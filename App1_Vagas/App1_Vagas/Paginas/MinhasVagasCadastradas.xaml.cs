using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Vagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MinhasVagasCadastradas : ContentPage
	{
		public MinhasVagasCadastradas ()
		{
			InitializeComponent ();
		}




        // Método EditarAction
        public void EditarAction(object sender, EventArgs args)
        {
            //Navigation.PushAsync(new MinhasVagasCadastradas());
        }



        // Método ExcluirAction
        public void ExcluirAction(object sender, EventArgs args)
        {
            //Navigation.PushAsync(new MinhasVagasCadastradas());
        }

    }
}