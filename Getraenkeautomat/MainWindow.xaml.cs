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

namespace Getraenkeautomat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        //GeldeingabeClicks

        public void zuhoherbetrag()
        {
            string geldbetrag = Convert.ToString(Geldbetrag.Content);
            if (geldbetrag.Length>5)
            {
                Geldbetrag.Content = "Ungültig/Zu hoher Geldbetrag";
            }
        }

        private void Num1_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "1";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "1";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + "1";
                }
            }
            zuhoherbetrag();
        }
        private void Num2_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "2";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "2";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + "2";
                }
            }
            zuhoherbetrag();
        }
        private void Num3_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "3";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "3";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + "3";
                }
            }
            zuhoherbetrag();
        }
        private void Num4_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "4";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "4";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + "4";
                }
            }
            zuhoherbetrag();
        }
        private void Num5_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "5";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "5";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + "5";
                }
            }
            zuhoherbetrag();
        }
        private void Num6_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "6";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "6";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + "6";
                }
            }
            zuhoherbetrag();
        }
        private void Num7_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "7";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "7";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + "7";
                }
            }
            zuhoherbetrag();
        }
        private void Num8_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "8";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "8";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + "8";
                }
            } 
            zuhoherbetrag();
        }
        private void Num9_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "9";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "9";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + "9";
                }
            }
            zuhoherbetrag();
        }
        private void NumDot_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "Ungültig/Zu hoher Geldbetrag";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "Ungültig/Zu hoher Geldbetragg";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + ".";
                }
            }
            zuhoherbetrag();
        }
        private void Num0_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "0";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "0";
                }
                else
                {
                    Geldbetrag.Content = Geldbetrag.Content + "0";
                }
            }
            zuhoherbetrag();
        }
        
//Clear Click
        private void NumClear_OnClick(object sender, RoutedEventArgs e)
        {
            Geldbetrag.Content = "---";
            Ausgabe.Content = "---";
            Produkt.Source = new BitmapImage(new Uri(@"/Assets/Transparent.png", UriKind.Relative));
        }
        
        
//Produkte Clicks
        private void Airwaves_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "1.50";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "1.50";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 1.50)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Airwaves-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 1.50;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }
        }

        private void Feuerzeug_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "1.50";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "1.50";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 1.50)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Feuerzeug-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 1.50;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }
        }

        private void Redbull_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "2.50";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "2.50";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 2.50)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Redbull-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 2.50;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void Snickers_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "1.50";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "1.50";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 1.50)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Snickers-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 1.50;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void CapriOrange_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "1.00";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "1.00";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 1.00)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Capri_Orange-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 1.00;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void Cola_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "3.50";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "3.50";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 3.50)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Coca_Cola-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 3.50;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void ComellaChoco_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "3.00";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "3.00";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 3.00)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Comella_Choco-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 3.00;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void LiptonSeftali_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "3.80";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "3.80";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 3.80)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Lipton_Seftali-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 3.80;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void MundMs_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "5.30";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "5.30";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 5.30)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/M_und_Ms-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 5.30;
                        Ausgabe.Content = Restgeld;
                    }
                } 
            }        }

        private void VitelWasser_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "1.50";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "1.50";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 1.50)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Vittel_Wasser-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 1.50;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void Nature_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "5.80";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "5.80";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 5.80)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Zweifel_Nature-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 5.80;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void Paprika_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "5.80";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "5.80";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 5.80)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Zweifel_Paprika-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 5.80;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void Wave_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "4.60";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "4.60";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 4.60)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Zweifel_Wave-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 4.60;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void IceTeaCannabis_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "2.50";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "2.50";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 2.50)
                    {
                        //Ausgeben
                        Produkt.Source = new BitmapImage(new Uri(@"/Assets/Ice_Tea_Cannabis-removebg-preview.png", UriKind.Relative));
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 2.50;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void VitaminWater_OnClick(object sender, RoutedEventArgs e)
        {
            if (Geldbetrag.Content == "---")
            {
                Geldbetrag.Content = "1.80";
            }
            else
            {
                if (Geldbetrag.Content == "Ungültig/Zu hoher Geldbetrag")
                {
                    Geldbetrag.Content = "1.80";
                }
                else
                {
                    if (Convert.ToDouble(Geldbetrag.Content) > 1.80)
                    {
                        //Ausgeben
                        //Geld Abziehen
                        Double Restgeld = Convert.ToDouble(Geldbetrag.Content) - 1.80;
                        Ausgabe.Content = Restgeld;
                    }
                }
            }        }

        private void ProduktButton_OnClick(object sender, RoutedEventArgs e)
        {
            Produkt.Source = new BitmapImage(new Uri(@"/Assets/Transparent.png", UriKind.Relative));
            
        }
        
    }
}