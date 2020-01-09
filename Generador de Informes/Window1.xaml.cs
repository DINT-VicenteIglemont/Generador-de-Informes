using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Generador_de_Informes {
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            reportViewer1.Owner = this;
            CrystalReport1 informe1 = new CrystalReport1();
            informe1.SetDatabaseLogon("administrador", "admin123.");
            reportViewer1.ViewerCore.ReportSource = informe1;

            reportViewer2.Owner = this;
            CrystalReport2 informe2 = new CrystalReport2();
            informe2.SetDatabaseLogon("administrador", "admin123.");
            reportViewer2.ViewerCore.ReportSource = informe2;

            reportViewer3.Owner = this;
            CrystalReport3 informe3 = new CrystalReport3();
            informe3.SetDatabaseLogon("administrador", "admin123.");
            reportViewer3.ViewerCore.ReportSource = informe3;

            reportViewer4.Owner = this;
            CrystalReport4 informe4 = new CrystalReport4();
            informe4.SetDatabaseLogon("administrador", "admin123.");
            reportViewer4.ViewerCore.ReportSource = informe4;

            reportViewer5.Owner = this;
            CrystalReport5 informe5 = new CrystalReport5();
            informe5.SetDatabaseLogon("administrador", "admin123.");
            reportViewer5.ViewerCore.ReportSource = informe5;
        }
    }
}
