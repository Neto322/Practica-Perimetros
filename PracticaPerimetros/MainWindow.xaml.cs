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

namespace PracticaPerimetros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ControlPerimetroCirculo.Visibility = Visibility.Collapsed;
            ControlPerimetroCuadrado.Visibility = Visibility.Collapsed;

            switch(cbTipoFigura.SelectedIndex)
            {
                case 0:
                    ControlPerimetroCirculo.Visibility = Visibility.Visible;
                    break;

                case 1:
                    ControlPerimetroCuadrado.Visibility = Visibility.Visible;
                    break;

                case 2:
                    ControlPerimetroTrapecio.Visibility = Visibility.Visible;
                    break;
                case 3:
                    ControlPerimetroTriangulo.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            float perimetro = 0.0f;

            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //circulo
                    float radio = float.Parse(ControlPerimetroCirculo.Radio.Text);
                    perimetro = 2 * radio * 3.134159f;
                    break;
                case 1: //cuadrado
                    float lado = float.Parse(ControlPerimetroCuadrado.PerimetroCuadrado.Text);
                    perimetro = lado * 4;
                    break;
                case 2:
                    float basemayor = float.Parse(ControlPerimetroTrapecio.BaseMayor.Text);
                    float basemenor = float.Parse(ControlPerimetroTrapecio.BaseMenor.Text);
                    float izquierda = float.Parse(ControlPerimetroTrapecio.LadoIzquierdo.Text);
                    float derecha = float.Parse(ControlPerimetroTrapecio.LadoDerecho.Text);
                    perimetro = basemayor + basemenor + izquierda + derecha;
                    break;
                case 3:
                    float basetri = float.Parse(ControlPerimetroTriangulo.Base.Text);
                    float izquierdatri = float.Parse(ControlPerimetroTriangulo.LadoIzquierdo.Text);
                    float derechatri = float.Parse(ControlPerimetroTriangulo.LadoDerecho.Text);
                    perimetro = basetri + izquierdatri + derechatri;
                    break;
            }
            Resultado.Text = perimetro.ToString() + "U²";
        }
    }
}
