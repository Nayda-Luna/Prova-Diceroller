namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

    }

    private void DiceRoller_Clicked(object sender, EventArgs e)
    {
        // int numeroaleatorio
        //()1+1
        int numeroSelecionado = Convert.ToInt32(SidesPicker.SelectedItem.ToString());
        
        int modificador = Convert.ToInt32(DicePicker.SelectedItem.ToString());

        int numerosDados = Convert.ToInt32(DiceEditor.ToString());
        {
            for (int i = 0, i < numerosDados, modificador) 
                ResultLabel.Text = numerosDados.ToString(); //laço- for
        }
           

        

        int numeroSorteado = new Random().Next(1, numeroSelecionado + 1);
        ResultLabel.Text = numeroSorteado.ToString();
    }
    


  //  private void DiceSide_Clicked(object sender, EventArgs e)
  //  {


  //  }

    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker

}

