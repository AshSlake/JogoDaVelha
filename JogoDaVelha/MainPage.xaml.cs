namespace JogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        //metodo de click dos botões
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
            else if (btn2_0.Text == "X" && btn2_1.Text == "X" && btn2_2.Text == "X")
            {
                DisplayAlert("Parabens", "X ganhou", "OK");
                Zerar();
            }
            else if (btn3_0.Text == "X" && btn3_1.Text == "X" && btn3_2.Text == "X")
            {
                DisplayAlert("Parabens", "X ganhou", "OK");
                Zerar();
            }
            //verificação se O ganhou
            else if (btn1_0.Text == "O" && btn1_1.Text == "O" && btn1_2.Text == "O")
            {
                DisplayAlert("Parabens", "O ganhou", "OK");
                Zerar();
            }
            else if (btn2_0.Text == "O" && btn2_1.Text == "O" && btn2_2.Text == "O")
            {
                DisplayAlert("Parabens", "O ganhou", "OK");
                Zerar();
            }
            else if (btn3_0.Text == "O" && btn3_1.Text == "O" && btn3_2.Text == "O")
            {
                DisplayAlert("Parabens", "O ganhou", "OK");
                Zerar();
            }
            //verificação se ouve ganhadores na diagonal
            //verificão de X
            else if (btn1_0.Text == "X" && btn2_1.Text == "X" && btn3_2.Text == "X")
            {
                DisplayAlert("Parabens", "X ganhou", "OK");
                Zerar();
            }
            else if (btn1_2.Text == "X" && btn2_1.Text == "X" && btn3_0.Text == "X")
            {
                DisplayAlert("Parabens", "X ganhou", "OK");
                Zerar();
            }
            //verificação de O
            else if (btn1_0.Text == "O" && btn2_1.Text == "O" && btn3_2.Text == "O")
            {
                DisplayAlert("Parabens", "O ganhou", "OK");
                Zerar();
            }
            else if (btn1_2.Text == "O" && btn2_1.Text == "O" && btn3_0.Text == "O")
            {
                DisplayAlert("Parabens", "O ganhou", "OK");
                Zerar();
            }
            //se nehuma das alternativas foi verdadeira então deu 
             verificarVelha();
            
        }

        //metodo para zera o jogo
        void Zerar()
        {
            btn1_0.Text = null;
            btn1_1.Text = null;
            btn1_2.Text = null;
            btn2_0.Text = null;
            btn2_1.Text = null;
            btn2_2.Text = null;
            btn3_0.Text = null;
            btn3_1.Text = null;
            btn3_2.Text = null;

            btn1_0.IsEnabled = true;
            btn1_1.IsEnabled = true;
            btn1_2.IsEnabled = true;
            btn2_0.IsEnabled = true;
            btn2_1.IsEnabled = true;
            btn2_2.IsEnabled = true;
            btn3_0.IsEnabled = true;
            btn3_1.IsEnabled = true;
            btn3_2.IsEnabled = true;

        }

        //metodo para verificar se deu velha
        void verificarVelha()
        {
            if (btn1_1.Text != null &&
            btn1_2.Text != null &&
            btn2_0.Text != null &&
            btn2_1.Text != null &&
            btn2_2.Text != null &&
            btn3_0.Text != null &&
            btn3_1.Text != null &&
            btn3_2.Text != null)
            {
                DisplayAlert("EITA DEU VELHA!!", "Vamos tentar denovo", "OK");
                Zerar();
            }
        }
    }

}
