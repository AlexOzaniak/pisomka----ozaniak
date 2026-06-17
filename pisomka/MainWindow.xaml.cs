using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
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

namespace pisomka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] ecv = {"KM-123CD (Price Per Km = 0.4)", "BA-123CD (Price Per Km = 0.4)", "ZA-124CD (Price Per Km = 0.4)" };

        public MainWindow()
        {

            InitializeComponent();
            foreach (var spz in ecv)
                cmb_Cars.Items.Add(spz);

        }


        private void cmb_Cars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            if (cmb_Cars.SelectedItem == "KM-123CD (Price Per Km = 0.4)")
            {

                pociatKM.Text = ($"{CarInfo.pociatocneKm.ToString()} km ");
            }
            else if (cmb_Cars.SelectedItem == "BA-123CD (Price Per Km = 0.4)")
            {

                pociatKM.Text = ($"{CarInfo.pociatocneKm1.ToString()} km ");
            }
            else if (cmb_Cars.SelectedItem == "ZA-124CD (Price Per Km = 0.4)")
            {

                pociatKM.Text = ($"{CarInfo.pociatocneKm2.ToString()} km ");
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmb_Cars.SelectedItem == "KM-123CD (Price Per Km = 0.4)")
                {
                    //   pociatKM.Text = CarInfo.pociatocneKm.ToString();
                    //    MessageBox.Show("zobrazene0");
                    CarInfo.ECV = "KM-123CD";

                    if (konecneKm.Text == null)
                    {
                        MessageBox.Show("Prejdene Km nemozu byt prazdne");
                    }
                    if (int.Parse(konecneKm.Text) < CarInfo.konecneKm)
                    {
                        MessageBox.Show("pocet najazdenych km nemoze byt meni ako pociatocny staav km");
                    }


                    else
                    {

                        CarInfo.konecneKm = int.Parse(konecneKm.Text);
                        CarInfo.priceperkm = 0.4;
                        int prejdeneKm = CarInfo.konecneKm - CarInfo.pociatocneKm;
                        MessageBox.Show($"Presiel si {prejdeneKm} Km  ");
                        var cena = prejdeneKm * CarInfo.priceperkm;
                        CarInfo.najazdeneKm = prejdeneKm;
                        MessageBox.Show($"stalo ta to {cena} eur ");
                        var celkomcena = CarInfo.konecneKm * CarInfo.priceperkm;
                        CarInfo.pociatocneKm = int.Parse(konecneKm.Text);
                        CarInfo.Celkovacena = celkomcena;
                        pociatKM.Text = ($"{CarInfo.pociatocneKm.ToString()} KM ");
                        string Uloz = ($"SPZ : {CarInfo.ECV}, Pociatocne KM : {CarInfo.pociatocneKm}, koncove Km : {CarInfo.konecneKm} najazdene: {CarInfo.najazdeneKm},Celkova Cena : {CarInfo.Celkovacena}");
                        lvAuta.Items.Add(Uloz);
                    }
                }



                else if (cmb_Cars.SelectedItem == "BA-123CD (Price Per Km = 0.4)")
                {
                    //pociatKM.Text = CarInfo.pociatocneKm1.ToString();
                    //   MessageBox.Show("zobrazene1");
                    CarInfo.ECV1 = "BA - 123CD";
                    if (konecneKm.Text == null)
                    {
                        MessageBox.Show("Prejdene Km nemozu byt prazdne");
                    }
                    if (int.Parse(konecneKm.Text) < CarInfo.konecneKm1)
                    {
                        MessageBox.Show("pocet najazdenych km nemoze byt meni ako pociatocny staav km");
                    }
                    else
                    {
                        CarInfo.konecneKm1 = int.Parse(konecneKm.Text);
                        CarInfo.priceperkm = 0.4;
                        int prejdeneKm = CarInfo.konecneKm1 - CarInfo.pociatocneKm1;
                        MessageBox.Show($"Presiel si {prejdeneKm} Km  ");
                        var cena = prejdeneKm * CarInfo.priceperkm1;
                        MessageBox.Show($"stalo ta to {cena} eur ");
                        CarInfo.najazdeneKm1 = prejdeneKm;
                        CarInfo.pociatocneKm1 = int.Parse(konecneKm.Text);
                        var celkomcena = CarInfo.konecneKm1 * CarInfo.priceperkm;
                        CarInfo.Celkovacena1 = celkomcena;
                        pociatKM.Text = ($"{CarInfo.pociatocneKm1.ToString()} KM ");
                        string Uloz = ($"SPZ : {CarInfo.ECV1}, Pociatocne KM : {CarInfo.pociatocneKm1}, koncove Km : {CarInfo.konecneKm1} najazdene: {CarInfo.najazdeneKm1},Celkova Cena: {CarInfo.Celkovacena1}");
                        lvAuta.Items.Add(Uloz);
                    }

                }
                else if (cmb_Cars.SelectedItem == "ZA-124CD (Price Per Km = 0.4)")
                {
                    //pociatKM.Text = CarInfo.pociatocneKm2.ToString();
                    //  MessageBox.Show("zobrazene2");
                    CarInfo.ECV2 = "BA - 123CD";
                    if (konecneKm.Text == null)
                    {
                        MessageBox.Show("Prejdene Km nemozu byt prazdne");
                    }
                    if (int.Parse(konecneKm.Text) < CarInfo.konecneKm2)
                    {
                        MessageBox.Show("pocet najazdenych km nemoze byt meni ako pociatocny staav km");
                    }
                    else
                    {
                        CarInfo.konecneKm2 = int.Parse(konecneKm.Text);
                        CarInfo.priceperkm = 0.4;
                        int prejdeneKm = CarInfo.konecneKm2 - CarInfo.pociatocneKm2;
                        MessageBox.Show($"Presiel si {prejdeneKm} Km  ");
                        var cena = prejdeneKm * CarInfo.priceperkm;
                        MessageBox.Show($"stalo ta to {cena} eur ");
                        CarInfo.najazdeneKm2 = prejdeneKm;
                        var celkomcena = CarInfo.konecneKm2 * CarInfo.priceperkm;
                        CarInfo.pociatocneKm2 = int.Parse(konecneKm.Text);
                        CarInfo.Celkovacena2 = celkomcena;
                        pociatKM.Text = ($"{CarInfo.pociatocneKm2.ToString()} KM ");
                        string Uloz = ($"SPZ : {CarInfo.ECV2}, Pociatocne KM : {CarInfo.pociatocneKm2}, koncove Km : {CarInfo.konecneKm2} najazdene: {CarInfo.najazdeneKm2},Celkova Cena : {CarInfo.Celkovacena2}");
                        lvAuta.Items.Add(Uloz);
                    }
                }
            }
            catch { }



        }

        private void konecneKm_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            konecneKm.Text = "";

        }
    }
}