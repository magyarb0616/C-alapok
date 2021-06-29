using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szoftechead
{
    class Calculator
    {

        Label maxDistance;
        Label currDistance;
        Label model;
        Label fuel;
        TextBox km;
        Button calculate;
        Button back;
        Label calcValue;
        Label ar;
        public Calculator()
        {
          
            this.model = new Label();
            this.model.Text = "Model: "; 
            this.model.Left = 15;
            this.model.Top = 50;
       

            this.fuel = new Label();
            this.fuel.Text = "Current fuel level:";
            this.fuel.Width = 400;
            this.fuel.Left = 15;
            this.fuel.Top = 100;

            this.maxDistance = new Label();
            this.maxDistance.Text = "Distance with full tank:";
            this.maxDistance.Width = 400;
            this.maxDistance.Left = 15;
            this.maxDistance.Top = 150;

            this.currDistance = new Label();
            this.currDistance.Text = "Distance with current fuel level:";
            this.currDistance.Width = 400;
            this.currDistance.Left = 15;
            this.currDistance.Top = 200;

            this.ar = new Label();
            this.ar.Text = "Megtenni kivant km:";
            this.ar.Width = 400;
            this.ar.Left = 15;
            this.ar.Top = 250;

            this.km = new TextBox();
            this.km.Top = 250;
            this.km.Left = 150;
            this.km.Width = 100;


            this.back = new Button();
            this.back.Width = 120;
            this.back.Top = 300;
            this.back.Left = 150;
            this.back.Height = 30;
            this.back.Text = "Back";

            this.calculate = new Button();
            this.calculate.Width = 120;
            this.calculate.Top = 300;
            this.calculate.Left = 15;
            this.calculate.Height = 30;
            this.calculate.Text = "Caluculate";

            this.calcValue = new Label();
            this.calcValue.Width = 400;
            this.calcValue.Left = 15;
            this.calcValue.Top = 350;


        }

        public Calculator Add(Control parent)
        {

            parent.Controls.Add(model);
            parent.Controls.Add(maxDistance);
            parent.Controls.Add(currDistance);
            parent.Controls.Add(fuel);
            parent.Controls.Add(km);
            parent.Controls.Add(back);
            parent.Controls.Add(calculate);
            parent.Controls.Add(calcValue);
            parent.Controls.Add(ar);

            return this;
        }

        public void SetInvisible()
        {
            model.Visible = false;
            maxDistance.Visible = false;
            currDistance.Visible = false;
            fuel.Visible = false;
            km.Visible = false;
            calculate.Visible = false;
            back.Visible = false;
        }

        public void SetVisible()
        {
            model.Visible = true;
            maxDistance.Visible = true;
            currDistance.Visible = true;
            fuel.Visible = true;
            km.Visible = true;
            calculate.Visible = true;
            back.Visible = true;

        }

        public Calculator BackClick(EventHandler evt)
        {
            this.back.Click += evt;
            return this;
        }

        public Calculator CalculateClick(EventHandler evt)
        {
            this.calculate.Click += evt;
            return this;
        }

        public void setModel(String s)
        {
            this.model.Text = s;
        }

        public void setFuel(String s)
        {
            this.fuel.Text = s;
        }

        public void setMaxdistance(String s)
        {
            this.maxDistance.Text = s;
        }

        public void setCurrDistance(String s)
        {
            this.currDistance.Text = s;
        }

        public int getKm()
        {
            return Int32.Parse(this.km.Text);
        }

        public void setAr(String s)
        {
            this.calcValue.Text = s;
        }


    }
}
