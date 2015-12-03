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

        private void Materia_Checked(object sender, RoutedEventArgs e)
        {
            if (checkMateria.IsEnabled)
            {
                quesitMateria = true;
            }
            else
            {
                quesitMateria = false;
            }
        }

        private void btnChecar_Click(object sender, RoutedEventArgs e)
        {
            saida = quesitMateria || quesitAulas && quesitEstudei || !quesitAulas && !quesitEstudei && quesitColei;
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

        private void Aulas_Checked(object sender, RoutedEventArgs e)
        {
            if (checkAulas.IsEnabled)
            {
                quesitAulas = true;
            }
            else
            {
                quesitAulas = false;
            }
        }

        private void Colei_Checked(object sender, RoutedEventArgs e)
        {
            if (checkColei.IsEnabled)
            {
                quesitColei = true;
            }
            else
            {
                quesitColei = false;
            }
        }

        private void Estudei_Checked(object sender, RoutedEventArgs e)
        {
            if (checkEstudei.IsEnabled)
            {
                quesitEstudei = true;
            }
            else
            {
                quesitEstudei = false;
            }
        }
    }
}
