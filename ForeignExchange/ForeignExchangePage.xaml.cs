using Xamarin.Forms;

namespace ForeignExchange
{
    public partial class ForeignExchangePage : ContentPage
    {
        public ForeignExchangePage()
        {
            InitializeComponent();

            ConvertButton.Clicked += ConvertButton_Clicked;
        }

        void ConvertButton_Clicked(object sender, System.EventArgs e)
        {
            if(string.IsNullOrEmpty(PesosEntry.Text))
            {
				DisplayAlert("Error", "You most enter a value...", "Accept");
				return;
            }  
               decimal pesos = 0;
               if (!decimal.TryParse(PesosEntry.Text, out pesos)) 
            {
				DisplayAlert("Error", "You most enter a numeric value...", "Accept");
                PesosEntry.Text = null;
                return;

            }
               
            var dollars = pesos / 17.5M;
            var euros = pesos / 18.5M;
            var pounds = pesos / 19.5M;

            DollarsEntry.Text = string.Format("${0:N2}", dollars);
            EurosEntry.Text   = string.Format("€{0:N2}", euros);
            PoundsEntry.Text  = string.Format("£{0:N2}", pounds);
        }
    }
}
