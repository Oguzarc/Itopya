
using İtopya.Claslar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using İtopya.Sayfalar;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using İtopya.ServiceReference1;

namespace İtopya
{

    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int toplamfiyat = 0;

        public MainWindow()
        {
            InitializeComponent();
            Anasayfa.Visibility = Visibility.Visible;          
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (AnaMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(800, GridUnitType.Auto);
                grd_rowMenu.Height = grd;
                AnaMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_rowMenu.Height = grd;
                AnaMenu.Visibility = Visibility.Hidden;
            }
        }

        int count = 0;
        private void PcParca_Click(object sender, RoutedEventArgs e)
        {
            if (count == 0)
            {
                GridLength grd2 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu12.Height = grd2;
                GridLength grd1 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu1.Height = grd1;
                GridLength grd = new GridLength(148, GridUnitType.Auto);
                grd_submenu11.Height = grd;
                GridLength grd3 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu2.Height = grd3;
                GridLength grd4 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu21.Height = grd4;
                GridLength grd5 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu22.Height = grd5;
                GridLength grd6 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu3.Height = grd6;
                count++;
                count1 = 0;
                count3 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
            }
            else if (count > 0)
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_submenu11.Height = grd;
                count = 0;
            }
        }

        int count1 = 0;
        private void Bilgisayar_Click(object sender, RoutedEventArgs e)
        {
            if (count1 == 0)
            {
                GridLength grd2 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu12.Height = grd2;
                GridLength grd1 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu11.Height = grd1;
                GridLength grd = new GridLength(148, GridUnitType.Auto);
                grd_submenu1.Height = grd;
                GridLength grd3 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu2.Height = grd3;
                GridLength grd4 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu21.Height = grd4;
                GridLength grd5 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu22.Height = grd5;
                GridLength grd6 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu3.Height = grd6;
                count1++;
                count = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
            }
            else if (count1 > 0)
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_submenu1.Height = grd;
                count1 = 0;
            }
        }
        int count3 = 0;
        private void Gaming_Click(object sender, RoutedEventArgs e)
        {
            if (count3 == 0)
            {

                GridLength grd1 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu1.Height = grd1;
                GridLength grd2 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu11.Height = grd2;
                GridLength grd3 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu2.Height = grd3;
                GridLength grd4 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu21.Height = grd4;
                GridLength grd5 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu22.Height = grd5;
                GridLength grd6 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu3.Height = grd6;
                GridLength grd = new GridLength(148, GridUnitType.Auto);
                grd_submenu12.Height = grd;
                count3++;
                count = 0;
                count1 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
            }
            else if (count3 > 0)
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_submenu12.Height = grd;
                count3 = 0;
            }
        }
        int count4 = 0;
        private void Cevre_Click(object sender, RoutedEventArgs e)
        {
            if (count4 == 0)
            {
                GridLength grd2 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu12.Height = grd2;
                GridLength grd1 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu1.Height = grd1;
                GridLength grd3 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu11.Height = grd3;
                GridLength grd4 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu21.Height = grd4;
                GridLength grd5 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu22.Height = grd5;
                GridLength grd6 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu3.Height = grd6;
                GridLength grd = new GridLength(148, GridUnitType.Auto);
                grd_submenu2.Height = grd;
                count4++;
                count1 = 0;
                count3 = 0;
                count3 = 0;
                count = 0;
                count5 = 0;
                count6 = 0;
                count7 = 0;
            }
            else if (count4 > 0)
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_submenu2.Height = grd;
                count4 = 0;
            }
        }
        int count5 = 0;
        private void Depolama_Click(object sender, RoutedEventArgs e)
        {
            if (count5 == 0)
            {
                GridLength grd2 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu12.Height = grd2;
                GridLength grd1 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu1.Height = grd1;
                GridLength grd4 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu11.Height = grd4;
                GridLength grd3 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu2.Height = grd3;
                GridLength grd5 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu22.Height = grd5;
                GridLength grd6 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu3.Height = grd6;
                GridLength grd = new GridLength(148, GridUnitType.Auto);
                grd_submenu21.Height = grd;
                count5++;
                count1 = 0;
                count3 = 0;
                count3 = 0;
                count4 = 0;
                count = 0;
                count6 = 0;
                count7 = 0;
            }
            else if (count5 > 0)
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_submenu21.Height = grd;
                count5 = 0;
            }
        }
        int count6 = 0;
        private void Network_Click(object sender, RoutedEventArgs e)
        {
            if (count6 == 0)
            {
                GridLength grd2 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu12.Height = grd2;
                GridLength grd1 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu1.Height = grd1;
                GridLength grd5 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu11.Height = grd5;
                GridLength grd3 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu2.Height = grd3;
                GridLength grd4 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu21.Height = grd4;
                GridLength grd6 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu3.Height = grd6;
                GridLength grd = new GridLength(148, GridUnitType.Auto);
                grd_submenu22.Height = grd;
                count6++;
                count1 = 0;
                count3 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count = 0;
                count7 = 0;
            }
            else if (count6 > 0)
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_submenu22.Height = grd;
                count6 = 0;
            }
        }
        int count7 = 0;
        private void Yazılım_Click(object sender, RoutedEventArgs e)
        {
            if (count7 == 0)
            {
                GridLength grd2 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu12.Height = grd2;
                GridLength grd1 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu1.Height = grd1;
                GridLength grd6 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu11.Height = grd6;
                GridLength grd3 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu2.Height = grd3;
                GridLength grd4 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu21.Height = grd4;
                GridLength grd5 = new GridLength(0, GridUnitType.Pixel);
                grd_submenu22.Height = grd5;
                GridLength grd = new GridLength(148, GridUnitType.Auto);
                grd_submenu3.Height = grd;
                count7++;
                count1 = 0;
                count3 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
                count6 = 0;
                count = 0;
            }
            else if (count7 > 0)
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_submenu3.Height = grd;
                count7 = 0;
            }
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ParcaMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(178, GridUnitType.Pixel);
                grd_AnaParça.Height = grd;
                ParcaMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_AnaParça.Height = grd;
                ParcaMenu.Visibility = Visibility.Hidden;
            }
        }

        private void DepoArtma_Click(object sender, RoutedEventArgs e)
        {
            if (DepoMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(134, GridUnitType.Pixel);
                grd_Depo.Height = grd;
                DepoMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Depo.Height = grd;
                DepoMenu.Visibility = Visibility.Hidden;
            }
        }

        private void PcArtma_Click(object sender, RoutedEventArgs e)
        {
            if (PcMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(157, GridUnitType.Pixel);
                grd_Pc.Height = grd;
                PcMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Pc.Height = grd;
                PcMenu.Visibility = Visibility.Hidden;
            }
        }

        private void YazılımArtma_Click(object sender, RoutedEventArgs e)
        {
            if (YazMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(70, GridUnitType.Pixel);
                grd_Yazılım.Height = grd;
                YazMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Yazılım.Height = grd;
                YazMenu.Visibility = Visibility.Hidden;
            }
        }

        private void Masaüstü_Click(object sender, RoutedEventArgs e)
        {
            if (MasaMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(110, GridUnitType.Pixel);
                grd_Masa.Height = grd;
                MasaMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Masa.Height = grd;
                MasaMenu.Visibility = Visibility.Hidden;
            }
        }

        private void NotebookArtma_Click(object sender, RoutedEventArgs e)
        {
            if (NotebookMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(88, GridUnitType.Pixel);
                grd_Notebook.Height = grd;
                NotebookMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Notebook.Height = grd;
                NotebookMenu.Visibility = Visibility.Hidden;
            }
        }

        private void NoteArtma_Click(object sender, RoutedEventArgs e)
        {
            if (NoteMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(88, GridUnitType.Pixel);
                grd_Note.Height = grd;
                NoteMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Note.Height = grd;
                NoteMenu.Visibility = Visibility.Hidden;
            }
        }

        private void YazılımArtma1_Click(object sender, RoutedEventArgs e)
        {
            if (YazMenu1.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(70, GridUnitType.Pixel);
                grd_Yazılım1.Height = grd;
                YazMenu1.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Yazılım1.Height = grd;
                YazMenu1.Visibility = Visibility.Hidden;
            }
        }


        private void GaksesuarArtma_Click(object sender, RoutedEventArgs e)
        {
            if (AksesuarMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(154, GridUnitType.Pixel);
                grd_Aksesuar.Height = grd;
                AksesuarMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Aksesuar.Height = grd;
                AksesuarMenu.Visibility = Visibility.Hidden;
            }
        }

        private void KonsolArtma_Click(object sender, RoutedEventArgs e)
        {
            if (KonsolMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(66, GridUnitType.Pixel);
                grd_Konsol.Height = grd;
                KonsolMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Konsol.Height = grd;
                KonsolMenu.Visibility = Visibility.Hidden;
            }
        }

        private void OyunArtma_Click(object sender, RoutedEventArgs e)
        {
            if (OyunMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(66, GridUnitType.Pixel);
                grd_Oyunlar.Height = grd;
                OyunMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Oyunlar.Height = grd;
                OyunMenu.Visibility = Visibility.Hidden;
            }
        }

        private void GamingArtma_Click(object sender, RoutedEventArgs e)
        {
            if (GamingMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(66, GridUnitType.Pixel);
                grd_Gaming.Height = grd;
                GamingMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Gaming.Height = grd;
                GamingMenu.Visibility = Visibility.Hidden;
            }
        }

        private void GaksesuarArtma1_Click(object sender, RoutedEventArgs e)
        {
            if (AksesuarMenu1.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(198, GridUnitType.Pixel);
                grd_gAksesuar.Height = grd;
                AksesuarMenu1.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_gAksesuar.Height = grd;
                AksesuarMenu1.Visibility = Visibility.Hidden;
            }
        }

        private void PcnoteArtma_Click(object sender, RoutedEventArgs e)
        {
            if (PcnoteMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(198, GridUnitType.Pixel);
                grd_pcNote.Height = grd;
                PcnoteMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_pcNote.Height = grd;
                PcnoteMenu.Visibility = Visibility.Hidden;
            }
        }

        private void YazArtma_Click(object sender, RoutedEventArgs e)
        {
            if (YazMenu2.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(66, GridUnitType.Pixel);
                grd_Yazıcı.Height = grd;
                YazMenu2.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Yazıcı.Height = grd;
                YazMenu2.Visibility = Visibility.Hidden;
            }
        }

        private void AksesuarArtma_Click(object sender, RoutedEventArgs e)
        {
            if (AksMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(154, GridUnitType.Pixel);
                grd_Aksesuar1.Height = grd;
                AksMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Aksesuar1.Height = grd;
                AksMenu.Visibility = Visibility.Hidden;
            }
        }

        private void dahiliArtma_Click(object sender, RoutedEventArgs e)
        {
            if (dahiliMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(154, GridUnitType.Pixel);
                grd_dahili.Height = grd;
                dahiliMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_dahili.Height = grd;
                dahiliMenu.Visibility = Visibility.Hidden;
            }
        }

        private void HariciArtma_Click(object sender, RoutedEventArgs e)
        {
            if (HariciMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(154, GridUnitType.Pixel);
                grd_harici.Height = grd;
                HariciMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_harici.Height = grd;
                HariciMenu.Visibility = Visibility.Hidden;
            }
        }

        private void AksesuarArtma1_Click(object sender, RoutedEventArgs e)
        {
            if (AksesuarMenu2.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(88, GridUnitType.Pixel);
                grd_Aksesuarlar.Height = grd;
                AksesuarMenu2.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_Aksesuarlar.Height = grd;
                AksesuarMenu2.Visibility = Visibility.Hidden;
            }
        }

        private void medemArtma_Click(object sender, RoutedEventArgs e)
        {
            if (modemMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(44, GridUnitType.Pixel);
                grd_modem.Height = grd;
                modemMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_modem.Height = grd;
                modemMenu.Visibility = Visibility.Hidden;
            }
        }

        private void ağArtma_Click(object sender, RoutedEventArgs e)
        {
            if (ağMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(176, GridUnitType.Pixel);
                grd_ağ.Height = grd;
                ağMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_ağ.Height = grd;
                ağMenu.Visibility = Visibility.Hidden;
            }
        }

        private void netArtma_Click(object sender, RoutedEventArgs e)
        {
            if (netMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(22, GridUnitType.Pixel);
                grd_network.Height = grd;
                netMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_network.Height = grd;
                netMenu.Visibility = Visibility.Hidden;
            }
        }

        private void depoArtma_Click(object sender, RoutedEventArgs e)
        {
            if (depoMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(66, GridUnitType.Pixel);
                grd_depolama.Height = grd;
                depoMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_depolama.Height = grd;
                depoMenu.Visibility = Visibility.Hidden;
            }
        }
        private void işletimArtma_Click(object sender, RoutedEventArgs e)
        {
            if (işletimMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(66, GridUnitType.Pixel);
                grd_işletim.Height = grd;
                işletimMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_işletim.Height = grd;
                işletimMenu.Visibility = Visibility.Hidden;
            }
        }

        private void officeArtma_Click(object sender, RoutedEventArgs e)
        {
            if (officeMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(66, GridUnitType.Pixel);
                grd_office.Height = grd;
                officeMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_office.Height = grd;
                officeMenu.Visibility = Visibility.Hidden;
            }
        }

        private void OyunArtma1_Click(object sender, RoutedEventArgs e)
        {
            if (OyunMenu1.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(66, GridUnitType.Pixel);
                grd_oyunlar.Height = grd;
                OyunMenu1.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_oyunlar.Height = grd;
                OyunMenu1.Visibility = Visibility.Hidden;
            }
        }

        private void güvenlikArtma_Click(object sender, RoutedEventArgs e)
        {
            if (güvenlikMenu.Visibility != Visibility.Visible)
            {
                GridLength grd = new GridLength(66, GridUnitType.Pixel);
                grd_güvenlik.Height = grd;
                güvenlikMenu.Visibility = Visibility.Visible;
            }
            else
            {
                GridLength grd = new GridLength(0, GridUnitType.Pixel);
                grd_güvenlik.Height = grd;
                güvenlikMenu.Visibility = Visibility.Hidden;
            }
        }

        private void anakartbuton_Click(object sender, RoutedEventArgs e)
        {
            Anakart.Visibility = Visibility.Visible;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Hidden;
            Satınal.Height = 0;
            Sepet.Height = 0;

        }

        private void islemcibuton_Click(object sender, RoutedEventArgs e)
        {
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Visible;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Hidden;
            Satınal.Height = 0;
            Sepet.Height = 0;
        }

        private void rambuton_Click(object sender, RoutedEventArgs e)
        {
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Visible;
            Ssd.Visibility = Visibility.Hidden;
            Satınal.Height = 0;
            Sepet.Height = 0;
        }

        private void ssdbuton_Click(object sender, RoutedEventArgs e)
        {
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Visible;
            Satınal.Height = 0;
            Sepet.Height = 0;
        }

        private void harddiskbuton_Click(object sender, RoutedEventArgs e)
        {
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Visible;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Hidden;
            Satınal.Height = 0;
            Sepet.Height = 0;
        }

        private void ofisyazilimbuton_Click(object sender, RoutedEventArgs e)
        {
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Visible;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Hidden;
            Satınal.Height = 0;
            Sepet.Height = 0;
        }

        private void isletimsistemleributon_Click(object sender, RoutedEventArgs e)
        {
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Visible;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Hidden;
            Satınal.Height = 0;
            Sepet.Height = 0;

        }

        private void guvenlikyazilimlaributon_Click(object sender, RoutedEventArgs e)
        {
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Visible;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Hidden;
            Satınal.Height = 0;
            Sepet.Height = 0;
        }

        private void  haricisdiskbuton_Click(object sender, RoutedEventArgs e)
        {
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Visible;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Hidden;
            Satınal.Height = 0;
            Sepet.Height = 0;
        }

        private void ekrankartibuton_Click(object sender, RoutedEventArgs e)
        {
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Visible;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Hidden;
            Satınal.Height = 0;
            Sepet.Height = 0;
        }

     
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(Sepet.Height==0 & toplamfiyat == 0)
            {
                MessageBox.Show("SEPETINIZDE URUN BULUNMAMAKTADIR.");
            }
         
          else if (Sepet.Height == 0 & toplamfiyat>0)
            {
                Sepet.Height = 1000;
                Sayfa.Visibility = Visibility.Hidden;
            }

            else
            {
                Sepet.Height = 0;
                Sayfa.Visibility = Visibility.Visible;
            }
        }

       

        private void urun1sil_Click(object sender, RoutedEventArgs e)
        {
            Urun1foto.Visibility = Visibility.Hidden;
            Urun1label.Visibility = Visibility.Hidden;
            urun1sil.Visibility = Visibility.Hidden;
            Urun1silf.Visibility = Visibility.Hidden;
            Urun1.Visibility = Visibility.Hidden;

            Urun1.Height = 0;
            toplamfiyat = toplamfiyat - 1024;
            Toplamfiyat.Content = toplamfiyat;
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepetten Çıkartıldı !");


        }

        private void urun2sil_Click(object sender, RoutedEventArgs e)
        {
            Urun2foto.Visibility = Visibility.Hidden;
            Urun2label.Visibility = Visibility.Hidden;
            urun2sil.Visibility = Visibility.Hidden;
            Urun2silf.Visibility = Visibility.Hidden;
            Urun2.Visibility = Visibility.Hidden;

            Urun2.Height = 0;
            toplamfiyat = toplamfiyat - 1036;
            Toplamfiyat.Content = toplamfiyat;
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepetten Çıkartıldı !");

        }

        private void urun3sil_Click(object sender, RoutedEventArgs e)
        {
            Urun3foto.Visibility = Visibility.Hidden;
            Urun3label.Visibility = Visibility.Hidden;
            urun3sil.Visibility = Visibility.Hidden;
            Urun3silf.Visibility = Visibility.Hidden;
            Urun3.Visibility = Visibility.Hidden;

            Urun3.Height = 0;
            toplamfiyat = toplamfiyat - 4699;
            Toplamfiyat.Content = toplamfiyat;
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepetten Çıkartıldı !");

        }

        private void urun4sil_Click(object sender, RoutedEventArgs e)
        {
            Urun4foto.Visibility = Visibility.Hidden;
            Urun4label.Visibility = Visibility.Hidden;
            urun4sil.Visibility = Visibility.Hidden;
            Urun4silf.Visibility = Visibility.Hidden;
            Urun4.Visibility = Visibility.Hidden;

            Urun4.Height = 0;
            toplamfiyat = toplamfiyat - 3720;
            Toplamfiyat.Content = toplamfiyat;
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepetten Çıkartıldı !");

        }

        private void urun5sil_Click(object sender, RoutedEventArgs e)
        {
            Urun5foto.Visibility = Visibility.Hidden;
            Urun5label.Visibility = Visibility.Hidden;
            urun5sil.Visibility = Visibility.Hidden;
            Urun5silf.Visibility = Visibility.Hidden;
            Urun5.Visibility = Visibility.Hidden;

            Urun5.Height = 0;
            toplamfiyat = toplamfiyat - 299;
            Toplamfiyat.Content = toplamfiyat;
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepetten Çıkartıldı !");

        }

        private void urun6sil_Click(object sender, RoutedEventArgs e)
        {
            Urun6foto.Visibility = Visibility.Hidden;
            Urun6label.Visibility = Visibility.Hidden;
            urun6sil.Visibility = Visibility.Hidden;
            Urun6silf.Visibility = Visibility.Hidden;
            Urun6.Visibility = Visibility.Hidden;

            Urun6.Height = 0;
            toplamfiyat = toplamfiyat - 1550;
            Toplamfiyat.Content = toplamfiyat;
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepetten Çıkartıldı !");

        }

        private void urun7sil_Click(object sender, RoutedEventArgs e)
        {
            Urun7foto.Visibility = Visibility.Hidden;
            Urun7label.Visibility = Visibility.Hidden;
            urun7sil.Visibility = Visibility.Hidden;
            Urun7silf.Visibility = Visibility.Hidden;
            Urun7.Visibility = Visibility.Hidden;

            Urun7.Height = 0;
            toplamfiyat = toplamfiyat - 465;
            Toplamfiyat.Content = toplamfiyat;
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepetten Çıkartıldı !");

        }

        private void urun8sil_Click(object sender, RoutedEventArgs e)
        {
            Urun8foto.Visibility = Visibility.Hidden;
            Urun8label.Visibility = Visibility.Hidden;
            Urun8sil.Visibility = Visibility.Hidden;
            Urun8silf.Visibility = Visibility.Hidden;
            Urun8.Visibility = Visibility.Hidden;

            Urun8.Height = 0;
            toplamfiyat = toplamfiyat - 414;
            Toplamfiyat.Content = toplamfiyat;
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepetten Çıkartıldı !");

        }

        private void urun9sil_Click(object sender, RoutedEventArgs e)
        {
            Urun9foto.Visibility = Visibility.Hidden;
            Urun9label.Visibility = Visibility.Hidden;
            Urun9sil.Visibility = Visibility.Hidden;
            Urun9silf.Visibility = Visibility.Hidden;
            Urun9.Visibility = Visibility.Hidden;
            Urun9.Height = 0;
            toplamfiyat = toplamfiyat - 414;
            Toplamfiyat.Content = toplamfiyat;
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepetten Çıkartıldı !");

        }


    




    private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Sepet.Height = 0;
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Visible;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Hidden;
            Sayfa.Visibility = Visibility.Visible;
            AnaMenu.Visibility = Visibility.Hidden;
            Satınal.Height = 0;
            Sepet.Height = 0;
            GridLength grd = new GridLength(0, GridUnitType.Pixel);
            grd_rowMenu.Height = grd;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Urun1label.Content = "ASUS Z390 ANAKART + \n" +
                "CORSAIR H45 SIVI SOĞUTMA";
            Urun1foto.Source = new BitmapImage(new Uri(@"C:\Users\user\source\repos\İtopya\İtopya\Image\asus1.jpg"));
            Urun1foto.Visibility = Visibility.Visible;
            Urun1label.Visibility = Visibility.Visible;
            urun1sil.Visibility = Visibility.Visible;
            Urun1silf.Visibility = Visibility.Visible;
            Urun1.Height = 90;
            toplamfiyat = toplamfiyat + 1024;
            Toplamfiyat.Content = toplamfiyat;
            Urun1.Visibility = Visibility.Visible;
            Urun1fiyat.Content = "1024";
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepete Eklendi !");

        }

        private void Buton2urun_Click(object sender, RoutedEventArgs e)
        {
           
            Urun2label.Content = "ASUS ROG MAXIMUS XI HERO WiFi\n Intel Z390 9th Gen Intel Soket 1151\n DDR4 4400MHz(O.C.) HDMI DP\n RGB Anakart";
            Urun2foto.Source = new BitmapImage(new Uri(@"C:\Users\user\source\repos\İtopya\İtopya\Image\asus2.jpg"));
            Urun2foto.Visibility = Visibility.Visible;
            Urun2label.Visibility = Visibility.Visible;
            urun2sil.Visibility = Visibility.Visible;
            Urun2silf.Visibility = Visibility.Visible;
            Urun2.Height = 90;
            toplamfiyat = toplamfiyat + 1036;
            Toplamfiyat.Content = toplamfiyat;
            Urun2.Visibility = Visibility.Visible;
            Urun2fiyat.Content = "1036";
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepete Eklendi !");



        }


        private void Buton3urun_Click(object sender, RoutedEventArgs e)
        {

            Urun3label.Content = "DH-i1/Intel i5 9400F/Asus DUAL 1660 Ti\n O6G/8GB DDR4/480GB SSD/Gaming Bilgisayar";
            Urun3foto.Source = new BitmapImage(new Uri(@"C:\Users\user\source\repos\İtopya\İtopya\Image\kasa2.jpg"));
            Urun3foto.Visibility = Visibility.Visible;
            Urun3label.Visibility = Visibility.Visible;
            urun3sil.Visibility = Visibility.Visible;
            Urun3silf.Visibility = Visibility.Visible;
            Urun3.Height = 90;
            toplamfiyat = toplamfiyat + 4699;
            Toplamfiyat.Content = toplamfiyat;
            Urun3.Visibility = Visibility.Visible;
            Urun3fiyat.Content = "4699";
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepete Eklendi !");


        }

        private void Buton4urun_Click(object sender, RoutedEventArgs e)
        {

            Urun4label.Content = "SHARK-2316/Ryzen 3 2300X/MSI GTX 1650\n GAMING X 4GB/8GB DDR4/1TB HDD\nGaming Bilgisayar";
            Urun4foto.Source = new BitmapImage(new Uri(@"C:\Users\user\source\repos\İtopya\İtopya\Image\kasa1.jpg"));
            Urun4foto.Visibility = Visibility.Visible;
            Urun4label.Visibility = Visibility.Visible;
            urun4sil.Visibility = Visibility.Visible;
            Urun4silf.Visibility = Visibility.Visible;
            Urun4.Height = 90;
            toplamfiyat = toplamfiyat + 3720;
            Toplamfiyat.Content = toplamfiyat;
            Urun4.Visibility = Visibility.Visible;
            Urun4fiyat.Content = "3720";
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepete Eklendi !");



        }

        private void Buton5urun_Click(object sender, RoutedEventArgs e)
        {

            Urun5label.Content = "Steelseries Apex 150 RGB \nTürkçe Q Oyuncu Klavyesi";
            Urun5foto.Source = new BitmapImage(new Uri(@"C:\Users\user\source\repos\İtopya\İtopya\Image\klavye.jpg"));
            Urun5foto.Visibility = Visibility.Visible;
            Urun5label.Visibility = Visibility.Visible;
            urun5sil.Visibility = Visibility.Visible;
            Urun5silf.Visibility = Visibility.Visible;
            Urun5.Height = 90;
            toplamfiyat = toplamfiyat + 299;
            Toplamfiyat.Content = toplamfiyat;
            Urun5.Visibility = Visibility.Visible;
            Urun5fiyat.Content = "299";
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepete Eklendi !");



        }

        private void Buton6urun_Click(object sender, RoutedEventArgs e)
        {

            Urun6label.Content = "AOC 24&quot; C24G1 2xHDMI DP \nVGA 144Hz 1MS Freesync Full\n HD Curved Gaming Monitör";
            Urun6foto.Source = new BitmapImage(new Uri(@"C:\Users\user\source\repos\İtopya\İtopya\Image\monitor.jpg"));
            Urun6foto.Visibility = Visibility.Visible;
            Urun6label.Visibility = Visibility.Visible;
            urun6sil.Visibility = Visibility.Visible;
            Urun6silf.Visibility = Visibility.Visible;
            Urun6.Height = 90;
            toplamfiyat = toplamfiyat + 1550;
            Toplamfiyat.Content = toplamfiyat;
            Urun6.Visibility = Visibility.Visible;
            Urun6fiyat.Content = "1550";
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepete Eklendi !");



        }

        private void Buton7urun_Click(object sender, RoutedEventArgs e)
        {

            Urun7label.Content = "MSI A320M PRO-M2 V2 AMD A320 \n Soket AM4 DDR4 3200MHz (OC) \n VGA DVI HDMI Anakart";
            Urun7foto.Source = new BitmapImage(new Uri(@"C:\Users\user\source\repos\İtopya\İtopya\Image\msi1.jpg"));
            Urun7foto.Visibility = Visibility.Visible;
            Urun7label.Visibility = Visibility.Visible;
            urun7sil.Visibility = Visibility.Visible;
            Urun7silf.Visibility = Visibility.Visible;
            Urun7.Height = 90;
            toplamfiyat = toplamfiyat + 465;
            Toplamfiyat.Content = toplamfiyat;
            Urun7.Visibility = Visibility.Visible;
            Urun7fiyat.Content = "465";
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepete Eklendi !");



        }

        private void Buton8urun_Click(object sender, RoutedEventArgs e)
        {

            Urun8label.Content = "MSI H310M PRO-VDH PLUS Intel H310 \n 8th Gen Intel Soket 1151 DDR4 \n 2666MHz VGA DVI HDMI Anakart";
            Urun8foto.Source = new BitmapImage(new Uri(@"C:\Users\user\source\repos\İtopya\İtopya\Image\msi2.jpg"));
            Urun8foto.Visibility = Visibility.Visible;
            Urun8label.Visibility = Visibility.Visible;
            Urun8sil.Visibility = Visibility.Visible;
            Urun8silf.Visibility = Visibility.Visible;
            Urun8.Height = 90;
            toplamfiyat = toplamfiyat + 414;
            Toplamfiyat.Content = toplamfiyat;
            Urun8.Visibility = Visibility.Visible;
            Urun8fiyat.Content = "414";
            MessageBox.Show("Ürününüz Başarılı Bir Şekilde Sepete Eklendi !");




        }
        private void satinal_Click(object sender, RoutedEventArgs e)
        {
            Sepet.Height = 0;
            Anakart.Visibility = Visibility.Hidden;
            Anasayfa.Visibility = Visibility.Hidden;
            EkranKarti.Visibility = Visibility.Hidden;
            GuvenlikYazilimlari.Visibility = Visibility.Hidden;
            Harddisk.Visibility = Visibility.Hidden;
            HariciDisk.Visibility = Visibility.Hidden;
            İslemci.Visibility = Visibility.Hidden;
            İsletimSistemleri.Visibility = Visibility.Hidden;
            OfisYazilim.Visibility = Visibility.Hidden;
            Ram.Visibility = Visibility.Hidden;
            Ssd.Visibility = Visibility.Hidden;
            Sayfa.Visibility = Visibility.Visible;
            AnaMenu.Visibility = Visibility.Hidden;
            Satınal.Height = 250;
        }

        private void odeme_Click(object sender, RoutedEventArgs e)
        {
            CalculatorClient kart = new CalculatorClient();

            if (kart.Kontrol(kartno.Text)==true && kart.Kontrolcvv(cvv.Text) == true&& kart.Kontroldate(yıl.Text)==true && kart.Kontrolay(ay.Text) == true)
            {
                MessageBox.Show("Satın alma işlemi tamamlandı!!!");
                Anasayfa.Visibility = Visibility.Visible;
                Satınal.Height = 0;
                Urun1.Height = 0;
                Urun2.Height = 0;
                Urun3.Height = 0;
                Urun4.Height = 0;
                Urun5.Height = 0;
                Urun6.Height = 0;
                Urun7.Height = 0;
                Urun8.Height = 0;
                toplamfiyat = 0;
                Toplamfiyat.Content = toplamfiyat;
            }
            else
            {
                MessageBox.Show("Satın Alma hatalı Hatalı!!!");
            }
            kartno.Clear();
            cvv.Clear();
            yıl.Clear();
            ay.Clear();          
        }
    }
}



