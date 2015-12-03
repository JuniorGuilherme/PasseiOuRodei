using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasseiOuRodei
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   bool quesitMateria, quesitEstudei, quesitColei, quesitAulas, saida;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, RoutedEventArgs e)
        {
            quesitMateria = checkMateria.IsChecked == true ? true : false;
            quesitAulas = checkAulas.IsChecked == true ? true : false;
            quesitColei = checkColei.IsChecked == true ? true : false;
            quesitEstudei = checkEstudei.IsChecked == true ? true : false;

            saida = quesitMateria || (quesitAulas && quesitEstudei) || (!quesitAulas && !quesitEstudei) && quesitColei || quesitColei;
            if (saida == true)
            {
                txtResult.Foreground = new SolidColorBrush(Colors.Green);
                txtResult.Text = "APROVADO";
            }
            else
            {
                txtResult.Foreground = new SolidColorBrush(Colors.Red);
                txtResult.Text = "REPROVADO";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Clear();
            checkAulas.IsChecked = false;
            checkEstudei.IsChecked = false;
            checkMateria.IsChecked = false;
            checkColei.IsChecked = false;
            saida = false;

        }
    }
}
