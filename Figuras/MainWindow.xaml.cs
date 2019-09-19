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

namespace Figuras
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

        private void CalcularRectangulo_Click(object sender, RoutedEventArgs e)
        {
            int rectangulobase =
                int.Parse(BaseRectangulo.Text);
            int rectanguloaltura =
                int.Parse(AlturaRectangulo.Text);
            int resultado = rectangulobase + rectanguloaltura;
            AreaRectangulo.Text = resultado.ToString();
        }

        private void CalcularTriangulo_Click(object sender, RoutedEventArgs e)
        {
            double triangulobase =
                double.Parse(BaseTriangulo.Text);
            double trianguloaltura =
                double.Parse(AlturaTriangulo.Text);
            double resultadotriangulo = triangulobase * trianguloaltura / 2;
            Areadtriangulo.Text = resultadotriangulo.ToString();
        }

        private void CalcularCirculo_Click(object sender, RoutedEventArgs e)
        {
            double circuloradio =
                double.Parse(CirculoRadio.Text);
            double resultadocirculo = Math.PI * (circuloradio * circuloradio);
            areacirculo.Text = resultadocirculo.ToString();
        }

        private void CalcularTrapecio_Click(object sender, RoutedEventArgs e)
        {
            double trapeciomayor =
                double.Parse(BaseMayor.Text);
            double trapeciomenor =
                double.Parse(BaseMenor.Text);
            double trapecioaltura =
                double.Parse(AlturaTrapecio.Text);
            double resultadotrapecio = ((trapeciomayor + trapeciomenor) * trapecioaltura) / 2;
        }
    }
}
