using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace telepulesGUI
{

    public partial class Form1 : Form
    {
        public static List<string> TeruletiEgysegNeve = new List<string>();
        public static List<string> TeruletiEgysegSzintje = new List<string>();
        public static List<int> MegyeiJoguVarosokSzama = new List<int>();
        public static List<int> MegyeiJoguVarosokNepessege = new List<int>();
        public static List<int> VarosokSzama = new List<int>();
        public static List<int> VarosokNepessege = new List<int>();
        public static List<int> NagykozsegekSzama = new List<int>();
        public static List<int> NagykozsegekNepessege = new List<int>();
        public static List<int> KozsegekSzama = new List<int>();
        public static List<int> KozsegeKNepessege = new List<int>();
        public Form1()
        {
            Beolvas();
            
            InitializeComponent();
            for (int i = 0; i < TeruletiEgysegNeve.Count; i++)
            {
                teruletiEgysegNeveLbox.Items.Add(TeruletiEgysegNeve[i]);
                
            }

            
        }

        private void Beolvas()
        {
            try
            {
                StreamReader olvas = new StreamReader("telepulesek.csv", encoding: Encoding.UTF8);
                olvas.ReadLine();
                while (!olvas.EndOfStream)
                {
                    string sor = olvas.ReadLine();
                    TeruletiEgysegNeve.Add(sor.Split(';')[0]);
                    TeruletiEgysegSzintje.Add(sor.Split(';')[1]);
                    MegyeiJoguVarosokSzama.Add(Convert.ToInt32(sor.Split(';')[2]));
                    MegyeiJoguVarosokNepessege.Add(Convert.ToInt32(sor.Split(';')[3]));
                    VarosokSzama.Add(Convert.ToInt32(sor.Split(';')[4]));
                    VarosokNepessege.Add(Convert.ToInt32(sor.Split(';')[5]));
                    NagykozsegekSzama.Add(Convert.ToInt32(sor.Split(';')[6]));
                    NagykozsegekNepessege.Add(Convert.ToInt32(sor.Split(';')[7]));
                    KozsegekSzama.Add(Convert.ToInt32(sor.Split(';')[8]));
                    KozsegeKNepessege.Add(Convert.ToInt32(sor.Split(';')[9]));
                }
                olvas.Close();
            }
            catch (IOException)
            {

                Console.WriteLine("Hiba a fájl beolvasása közben");
            }
        }
    }
}
