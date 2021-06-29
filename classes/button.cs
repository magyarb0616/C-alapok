using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szoftechead
{
    class button
    {
        private const double ret = 0.0;
        Button add;
        Button next;
        TextBox model;
        TextBox capacity;
        TextBox fuel;
        TextBox consumption;
        Label lbl_model;
        Label lbl_capacity;
        Label lbl_fuel;
        Label lbl_consumption;


        public button()
        {


            this.lbl_model = new Label();
            this.lbl_model.Text = "Model:";
            this.lbl_model.Left = 15;
            this.lbl_model.Top = 50;


            this.model = new TextBox();
            this.model.Width = 150;
            this.model.Left = 120;
            this.model.Top = 50;


            this.lbl_capacity = new Label();
            this.lbl_capacity.Text = "Capacity:";
            this.lbl_capacity.Left = 15;
            this.lbl_capacity.Top = 100;


            this.capacity = new TextBox();
            this.capacity.Width = 150;
            this.capacity.Left = 120;
            this.capacity.Top = 100;


            this.lbl_fuel = new Label();
            this.lbl_fuel.Text = "Fuel:";
            this.lbl_fuel.Left = 15;
            this.lbl_fuel.Top = 150;

            this.fuel = new TextBox();
            this.fuel.Width = 150;
            this.fuel.Left = 120;
            this.fuel.Top = 150;

            this.lbl_consumption = new Label();
            this.lbl_consumption.Text = "Consumption:";
            this.lbl_consumption.Left = 15;
            this.lbl_consumption.Top = 200;

            this.consumption = new TextBox();
            this.consumption.Width = 150;
            this.consumption.Left = 120;
            this.consumption.Top = 200;

            //this.add = new Button();
            //this.add.Width = 120;
            //this.add.Top = 250;
            //this.add.Left = 150;
            //this.add.Height = 30;
            //this.add.Text = "Add vehicle";

            this.next = new Button();
            this.next.Width = 250;
            this.next.Top = 250;
            this.next.Left = 15;
            this.next.Height = 30;
            this.next.Text = "Calculator";

        }

        public button Add(Control parent)
        {

            parent.Controls.Add(lbl_model);
            parent.Controls.Add(model);
            parent.Controls.Add(lbl_capacity);
            parent.Controls.Add(capacity);
            parent.Controls.Add(lbl_fuel);
            parent.Controls.Add(fuel);
            parent.Controls.Add(lbl_consumption);
            parent.Controls.Add(consumption);
            //parent.Controls.Add(add);
            parent.Controls.Add(next);
            return this;
        }

        public button AddClick(EventHandler evt)
        {
            this.add.Click += evt;
            return this;
        }

        public button NextClick(EventHandler evt)
        {
            this.next.Click += evt;
            return this;
        }

        public String getModel()
        {
            return model.Text;
        }

        public float getCapacity()
        {
            try
            {
                return float.Parse(capacity.Text);
            }
            catch (Exception ex)
            {
                return (float)ret;
                MessageBox.Show(ex.ToString());
            }


        }

        public float getFuel()
        {
            try
            {
                return float.Parse(fuel.Text);
            }
            catch (Exception ex)
            {
                return (float)ret;
                MessageBox.Show(ex.ToString());
            }

        }

        public float getConsumption()
        {
            try
            {
                return float.Parse(consumption.Text);
            }
            catch (Exception ex)
            {
                return (float)ret;
                MessageBox.Show(ex.ToString());
            }

        }

        public void SetInvisible()
        {
            lbl_capacity.Visible = false;
            lbl_consumption.Visible = false;
            lbl_fuel.Visible = false;
            lbl_model.Visible = false;

            model.Visible = false;
            capacity.Visible = false;
            fuel.Visible = false;
            consumption.Visible = false;

            //add.Visible = false;
            next.Visible = false;

        }

        public void SetVisible()
        {
            lbl_capacity.Visible = true;
            lbl_consumption.Visible = true;
            lbl_fuel.Visible = true;
            lbl_model.Visible = true;

            model.Visible = true;
            capacity.Visible = true;
            fuel.Visible = true;
            consumption.Visible = true;
            next.Visible = true;

        }
    }
}
