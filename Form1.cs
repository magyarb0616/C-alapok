using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szoftechead
{
    public partial class Form1 : Form
    {
        private const double uzemanyagar = 365.47;
        button entity = new button();
        Calculator Centity = new Calculator();
        
        public Form1()
        {
            InitializeComponent();
            entity.Add(this);
            entity.NextClick(NextClick);
            Centity.BackClick(BackClick);
            Centity.CalculateClick(CalculateClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void NextClick(object sender, EventArgs e)
        {
            entity.SetInvisible();
            Centity.Add(this);
            Centity.SetVisible();
            Centity.setModel(entity.getModel());
            Centity.setFuel("Fuel capacity: " + entity.getFuel().ToString() + " l");
            float lperkm = entity.getConsumption() / 100;
            float maxDist = entity.getCapacity() / lperkm;
            float currDist = entity.getFuel() / lperkm;
            Centity.setMaxdistance("Distance with full tank: " + maxDist + " km");
            Centity.setCurrDistance("Distance with current fuel level: " + currDist + " km");

        }

        public void BackClick(object sender, EventArgs e)
        {
            Centity.SetInvisible();
            entity.SetVisible();
            Centity.setAr("");
        
        }

        public void CalculateClick(object sender, EventArgs e)
        {
            float lperkm = entity.getConsumption() / 100;
            float felhasznalt = Centity.getKm()*lperkm;
            float ar = (float)(felhasznalt * uzemanyagar);

            Centity.setAr(felhasznalt + " l fuel used, cost: " + ar + " ft");



        }



    }
}
