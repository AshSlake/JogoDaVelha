namespace JogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            /*verificação se X ganhou na primeira linha*/
            if (btn1_0.Text == "X" && btn1_1.Text == "X" && btn1_2.Text == "X")
            {
                DisplayAlert("Parabens", "X ganhou", "OK");
                Zerar();
            }

        }

        void Zerar()
        {
            btn1_0.Text = "";
            btn1_1.Text = "";
            btn1_2.Text = "";

            btn1_0.IsEnabled = true;
            btn1_1.IsEnabled = true;
            btn1_2.IsEnabled = true;
        }
    }

}
