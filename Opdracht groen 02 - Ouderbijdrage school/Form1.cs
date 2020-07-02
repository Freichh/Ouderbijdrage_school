using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Opdracht_groen_02___Ouderbijdrage_school
{
    /// <summary>
    /// Ouderbijdrage school
    /// Een basisschool berekent de ouderbijdrage als volgt:
    /// • Een basisbedrag van € 50,=. Daarnaast voor elk kind jonger dan 10 jaar € 25,= 
    /// (voor maximaal 3 kinderen) en voor elk kind van 10 jaar en ouder € 37,= (voor maximaal 2 kinderen).
    /// • De maximale ouderbijdrage bedraagt € 150,=.
    /// • Voor éénoudergezinnen wordt op de berekende bijdrage(nádat de controle op het maximum
    /// heeft plaatsgevonden) een reductie toegepast van 25%.
    /// De te ontwikkelen software moet aan de hand van de gezinsgegevens de verschuldigde ouderbijdrage bepalen. 
    /// De leeftijd van elk kind moet aan de hand van geboortedatum en een peildatum worden berekend
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool eenOuderGezin = false;
        private void eenOuderGezinCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (eenOuderGezinCheckbox.Checked == true)
            {
                eenOuderGezin = true;
            }
            else
            {
                eenOuderGezin = false;
            }
        }

        int aantalKinderen = 0;
        private void aantalKinderenNumeric_ValueChanged(object sender, EventArgs e)
        {
            aantalKinderen = Convert.ToInt32(aantalKinderenNumeric.Value);
            if (aantalKinderen > 0)
            {
                CreateBirthdays(aantalKinderen);
            }
        }
         
        public void CreateBirthdays(int kinderen)
        {
            // clear on each numeric change
            geboortedatumFlowLayoutPanel.Controls.Clear();
            
            for (int i = 1; i < kinderen + 1; i++)
            {
                Label label = new Label();
                DateTimePicker dateTimePicker = new DateTimePicker();

                // Initialize the Label and TextBox controls.
                label.Text = "Geboortedatum kind " + i;
                label.Size = new Size(150, 20);
                label.Name = "label" + i;
                label.Margin = new Padding(5, 5, 5, 2);
                dateTimePicker.Size = new Size(200, 20);
                dateTimePicker.Name = "dateTimePicker" + i;
                dateTimePicker.Margin = new Padding(5, 5, 5, 15);

                // Add the Label and TextBox controls to the Panel.
                geboortedatumFlowLayoutPanel.Controls.Add(label);
                geboortedatumFlowLayoutPanel.Controls.Add(dateTimePicker);
            }
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            int kindOnderTien = 0;
            int kindBovenTien = 0;
            DateTime peilDatum = new DateTime(2020, 9, 1);

            //loop all child controls from geboortedatumFlowLayoutPanel
            foreach (Control c in geboortedatumFlowLayoutPanel.Controls)
            {
                //verzamel alle geboortedatums, maak er leeftijden van en sorteer ze
                if (c is DateTimePicker)
                {
                    //cast control to DateTimePicker control
                    DateTimePicker dtp = c as DateTimePicker;
                    DateTime geboortedatum = dtp.Value;

                    TimeSpan leeftijdSpan = peilDatum - geboortedatum;
                    int leeftijd = leeftijdSpan.Days / 365;
                    Debug.WriteLine("leeftijd " + leeftijd);

                    if (leeftijd < 10 && kindOnderTien < 3)
                    {
                        kindOnderTien += 1;
                        Debug.WriteLine("kindOnderTien " + kindOnderTien);
                    }
                    else if (leeftijd >= 10 && kindBovenTien < 2)
                    {
                        kindBovenTien += 1;
                        Debug.WriteLine("kindBovenTien " + kindBovenTien);
                    }
                }
            }

            berekenBedrag(kindOnderTien, kindBovenTien);

        }

        private void berekenBedrag(int kindOnderTien, int kindBovenTien)
        {
            int basisBedrag = 50;
            int kindOnderTienBedrag = 25;
            int kindBovenTienBedrag = 37;
            double totaalBedrag = 0;

            totaalBedrag = basisBedrag + (kindOnderTien * kindOnderTienBedrag) + (kindBovenTien * kindBovenTienBedrag);
            if (totaalBedrag > 150)
            {
                totaalBedrag = 150;
            }
            if (eenOuderGezin == true)
            {
                totaalBedrag *= 0.75;
            }
            totaalbedragTextBox.Text = totaalBedrag.ToString("c", CultureInfo.CreateSpecificCulture("nl-NL"));
        }
    }
}
