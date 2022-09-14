using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace PrimeMinisters
{
    public partial class Form1 : Form
    {
        private Dictionary<string, PrimeMinister> primeMinisters = new Dictionary<string, PrimeMinister>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lastNames =
            {
                "Trudeau", "Harper", "Martin", "Chretien", "Campbell", "Mulroney", "Turner", "Clark"
            };

            foreach (string lastName in lastNames)
            {
                lstPrimeMinisters.Items.Add(lastName);
            }

            PopulatedPrimeMinisters();

            lstPrimeMinisters.DataSource = primeMinisters.Keys.ToList<string>();
        }

        private void lstPrimeMinisters_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrimeMinister primeMinisterFound = primeMinisters[lstPrimeMinisters.SelectedValue.ToString()];
            lblName.Text = primeMinisterFound.FirstName + " " + primeMinisterFound.LastName;
            lblTerm.Text = "Term: " + primeMinisterFound.Term;
            lblParty.Text = "Party: " + primeMinisterFound.Party;
            picPhoto.ImageLocation = primeMinisterFound.LastName + ".jpg";
        }

        private void PopulatedPrimeMinisters()
        {
            PrimeMinister pm1 = new PrimeMinister("Justin", "Trudeau", "4 November 2015 - Incumbent", "Liberal");
            PrimeMinister pm2 = new PrimeMinister("Stephen", "Harper", "6 February 2006 - 3 November 2015", "Conservative");
            PrimeMinister pm3 = new PrimeMinister("Paul", "Martin", "12 December 2003 - 6 February 2006", "Liberal");
            PrimeMinister pm4 = new PrimeMinister("Jean", "Chretien", "4 November 1993 - 11 December 2003", "Liberal");
            PrimeMinister pm5 = new PrimeMinister("Kim", "Campbell", "25 June 1993 - 3 November 1993", "Conservative");
            PrimeMinister pm6 = new PrimeMinister("Brian", "Mulroney", "17 September 1984 - 24 June 1993", "Conservative");
            PrimeMinister pm7 = new PrimeMinister("John", "Turner", "30 June 1984 - 16 September 1984", "Liberal");
            PrimeMinister pm8 = new PrimeMinister("Joe", "Clark", "4 June 1979 - 2 March 1980", "Conservative");

            primeMinisters.Add(pm1.LastName, pm1);
            primeMinisters.Add(pm2.LastName, pm2);
            primeMinisters.Add(pm3.LastName, pm3);
            primeMinisters.Add(pm4.LastName, pm4);
            primeMinisters.Add(pm5.LastName, pm5);
            primeMinisters.Add(pm6.LastName, pm6);
            primeMinisters.Add(pm7.LastName, pm7);
            primeMinisters.Add(pm8.LastName, pm8);
        }
    }
}
