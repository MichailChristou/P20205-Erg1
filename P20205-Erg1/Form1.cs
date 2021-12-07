using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P20205_Erg1
{
    public partial class Form1 : Form
    {
        //counter for traffic lights
        public int count = 0;
        Point Positioncar2;
        Point Positioncar3;
        Point Positioncar4;
        Point Positioncar5;
        Point Positioncar6;
        Point Positioncar7;


        public Form1()
        {
            InitializeComponent();

            //method for transparent pictureboxes
            pictureBox1.Controls.Add(pictureBox8);
            pictureBox8.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox3);
            pictureBox3.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox4);
            pictureBox4.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox5);
            pictureBox5.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox6);
            pictureBox6.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox7);
            pictureBox7.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(yellow1);
            yellow1.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(yellow2);
            yellow2.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(red1);
            red1.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(red2);
            red2.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(green1);
            green1.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(green2);
            green2.BackColor = Color.Transparent;

            green1.Visible = true;
            yellow1.Visible = false;
            red1.Visible = false;

            green2.Visible = false;
            yellow2.Visible = false;
            red2.Visible = true;

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            Positioncar2 = pictureBox2.Location;
            Positioncar3 = pictureBox3.Location;
            Positioncar4 = pictureBox4.Location;
            Positioncar5 = pictureBox5.Location;
            Positioncar6 = pictureBox6.Location;
            Positioncar7 = pictureBox7.Location;
        }

        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Enabled = false;
            if (timer2.Enabled)
                timer2.Enabled = false;
        }

        private void phusicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mystartbutton.Visible = true;
        }

        private void physicalFilishButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myfinishbutton.Visible = true;
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραθυρική εφαρμογή έχει κατασκευαστεί για να τρέχει αυστηρά στην προεπιλεγμένη διάσταση του παραθύρου(default). Η μετακίνηση του παραθύρου είναι δυνατή χωρίς να προκαλεί λειτουργικά προβλήματα στην εφαρμογή όπως και η επαναδιάταξη των διαστάσεων της με την μόνη διαφορά ότι το οπτικό αποτέλεσμα δεν είναι το επιθυμητό.");
        }

        private void buttonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(">Με το κουμπί Start του κεντρικού μενού μπορεί ο χρήστης να ξεκινήσει την εκτέλεση της εφαρμογής.\n> Με το κουμπί Finish του κεντρικού μενού μπορεί ο χρήστης να τερματίσει την εκτέλεση της εφαρμογής.\n> Με την λειτουργία Create Buttons, που βρίσκεται στο κεντρικό μενού της εφαρμογής, μπορεί ο χρήστης να δημιουργήσει φυσικά κουμπιά για την έναρξη και τερματισμό της εκτέλεσης παρόμοια με το Start και Finish που βρίσκονται στο ίδιο μενού.\n> Στο Αbout υπάρχουν όλες οι χρήσιμες πληροφορίες που μπορεί να χρειαστεί ο χρήστης κατά την χρήση της εφαρμογής καθώς και τρόποι επικοινωνίας με τον δημιουργό για πιθανές ερωτήσεις ή αναφορές προβλημάτων(bugs).");
        }

        private void movementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η μετακίνηση των αυτοκίνητων και στους δυο δρόμους καθώς και η λειτουργία των φαναριών κυκλοφορίας γίνεται αυτόματα όταν ο χρήστης πατήσει το Start ή το αντίστοιχο φυσικό κουμπί που μπορεί να δημιουργήσει ο ίδιος. Η μόνη αλληλεπίδραση του χρήστη με την εφαρμογή στον τομέα της κίνησης των αμαξιών είναι μηδενική και οι μονές δυνατές λειτουργίες είναι η εκκίνηση και ο τερματισμός της κίνησης αυτής. ");
        }

        private void bugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Γνωστά bugs μέχρι τώρα:\n> Οι εικόνες των αυτοκίνητων και των σύννεφων παρουσιάζουν ένα περίεργο εφέ στην εικόνα του δρόμου κατά την ώρα της κίνησης .");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            count = count + 1;

            if (count == 5)
            {
                green1.Visible = false;
                yellow1.Visible = true;
                red1.Visible = false;
                green2.Visible = false;
                yellow2.Visible = false;
                red2.Visible = true;
            }
            else if (count == 7)
            {
                green1.Visible = false;
                yellow1.Visible = false;
                red1.Visible = true;
                green2.Visible = true;
                yellow2.Visible = false;
                red2.Visible = false;
            }
            else if (count == 12)
            {
                green1.Visible = false;
                yellow1.Visible = false;
                red1.Visible = true;
                green2.Visible = false;
                yellow2.Visible = true;
                red2.Visible = false;
            }
            else if (count == 14)
            {
                green1.Visible = true;
                yellow1.Visible = false;
                red1.Visible = false;
                green2.Visible = false;
                yellow2.Visible = false;
                red2.Visible = true;
                count = 0;
            }
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //cloud movement
            if (pictureBox8.Location.X < 920)
                pictureBox8.Location = new Point(pictureBox8.Location.X + 1, pictureBox8.Location.Y);
            else pictureBox8.Location = new Point((pictureBox8.Location.X * 0) - 100, pictureBox8.Location.Y);


            //horizontal road
            if (red2.Visible == false)
            {
                if (pictureBox2.Location.X < 920)
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
                else pictureBox2.Location = new Point((pictureBox2.Location.X * 0) - 100, pictureBox2.Location.Y);
            }
            else if (pictureBox2.Location.X > 250 || pictureBox2.Location.X < 100)
            {
                if (pictureBox2.Location.X < 920)
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
                else pictureBox2.Location = new Point((pictureBox2.Location.X * 0) - 100, pictureBox2.Location.Y);
            }
            
            else if (red2.Visible == true && pictureBox2.Location.X <= 250)
            {
                if (pictureBox3.Location.X <= 250 && pictureBox4.Location.X <= 250)
                {
                    if (pictureBox3.Location.X > pictureBox2.Location.X && pictureBox4.Location.X > pictureBox2.Location.X)
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y);
                    else if ((pictureBox3.Location.X > pictureBox2.Location.X || pictureBox4.Location.X > pictureBox2.Location.X) && pictureBox2.Location.X < 180)
                        pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
                    else if (pictureBox2.Location.X < 240)
                        pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
                }
                else if (pictureBox3.Location.X <= 250 || pictureBox4.Location.X <= 250)
                {
                    if ((pictureBox3.Location.X > pictureBox2.Location.X || pictureBox4.Location.X > pictureBox2.Location.X) && pictureBox2.Location.X < 180)
                        pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
                    else if (pictureBox2.Location.X < 240)
                        pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
                }
                else
                {
                    if (pictureBox2.Location.X < 250)
                        pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
                }

            }
            



            if (red2.Visible == false)
            {
                if (pictureBox3.Location.X < 920)
                    pictureBox3.Location = new Point(pictureBox3.Location.X + 10, pictureBox3.Location.Y);
                else pictureBox3.Location = new Point((pictureBox3.Location.X * 0) - 100, pictureBox3.Location.Y);
            }
            else if (red2.Visible == true && pictureBox3.Location.X > 250 || pictureBox3.Location.X < 100)
            {
                if (pictureBox3.Location.X < 920)
                    pictureBox3.Location = new Point(pictureBox3.Location.X + 10, pictureBox3.Location.Y);
                else pictureBox3.Location = new Point((pictureBox3.Location.X * 0) - 100, pictureBox3.Location.Y);
            }
            else if (red2.Visible == true && pictureBox3.Location.X <= 250)
            {
                if (pictureBox2.Location.X <= 250 && pictureBox4.Location.X <= 250)
                {
                    if (pictureBox2.Location.X > pictureBox3.Location.X && pictureBox4.Location.X > pictureBox3.Location.X)
                        pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
                    else if ((pictureBox2.Location.X > pictureBox3.Location.X || pictureBox4.Location.X > pictureBox3.Location.X) && pictureBox3.Location.X < 180)
                        pictureBox3.Location = new Point(pictureBox3.Location.X + 10, pictureBox3.Location.Y);
                }
                else if (pictureBox2.Location.X <= 250 || pictureBox4.Location.X <= 250)
                {
                    if ((pictureBox2.Location.X > pictureBox3.Location.X || pictureBox4.Location.X > pictureBox3.Location.X) && pictureBox3.Location.X < 180)
                        pictureBox3.Location = new Point(pictureBox3.Location.X + 10, pictureBox3.Location.Y);
                }
                else
                {
                    if (pictureBox3.Location.X < 250)
                        pictureBox3.Location = new Point(pictureBox3.Location.X + 10, pictureBox3.Location.Y);
                }

            }




            if (red2.Visible == false)
            {
                if (pictureBox4.Location.X < 920)
                    pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
                else pictureBox4.Location = new Point((pictureBox4.Location.X * 0) - 100, pictureBox4.Location.Y);
            }
            else if (red2.Visible == true && pictureBox4.Location.X > 250 || pictureBox4.Location.X < 100)
            {
                if (pictureBox4.Location.X < 920)
                    pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
                else pictureBox4.Location = new Point((pictureBox4.Location.X * 0) - 100, pictureBox4.Location.Y);
            }
            else if (red2.Visible == true && pictureBox4.Location.X <= 250)
            {
                if (pictureBox3.Location.X <= 250 && pictureBox2.Location.X <= 250)
                {
                    if (pictureBox3.Location.X > pictureBox4.Location.X && pictureBox2.Location.X > pictureBox4.Location.X)
                        pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y);
                    else if ((pictureBox3.Location.X > pictureBox4.Location.X || pictureBox2.Location.X > pictureBox4.Location.X) && pictureBox4.Location.X < 180)
                        pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
                }
                else if (pictureBox3.Location.X <= 250 || pictureBox2.Location.X <= 250)
                {
                    if ((pictureBox3.Location.X > pictureBox4.Location.X || pictureBox2.Location.X > pictureBox4.Location.X) && pictureBox4.Location.X < 180)
                        pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
                }
                else
                {
                    if (pictureBox4.Location.X < 250)
                        pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
                }

            }


            //vertical road
            if (red1.Visible == false)
            {
                if (pictureBox5.Location.Y > -50)
                    pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y - 10);
                else pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 800);
            }
            else if (red1.Visible == true && pictureBox5.Location.Y > 340 || pictureBox5.Location.Y < 300)
            {
                if (pictureBox5.Location.Y > -50)
                    pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y - 10);
                else pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 800);
            }



            if (red1.Visible == false)
            {
                if (pictureBox6.Location.Y > -50)
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 10);
                else pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 800);
            }
            else if (red1.Visible == true && pictureBox5.Location.Y > 340 || pictureBox6.Location.Y < 300)
            {
                if (pictureBox6.Location.Y > -50)
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 10);
                else pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 800);
            }



            if (red1.Visible == false)
            {
                if (pictureBox7.Location.Y > -50)
                    pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y - 10);
                else pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + 800);
            }
            else if (red1.Visible == true && pictureBox5.Location.Y > 340 || pictureBox7.Location.Y < 300)
            {
                if (pictureBox7.Location.Y > -50)
                    pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y - 10);
                else pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + 800);
            }


        }

        private void mystartbutton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            Positioncar2 = pictureBox2.Location;
            Positioncar3 = pictureBox3.Location;
            Positioncar4 = pictureBox4.Location;
            Positioncar5 = pictureBox5.Location;
            Positioncar6 = pictureBox6.Location;
            Positioncar7 = pictureBox7.Location;
        }

        private void myfinishbutton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Enabled = false;
            if (timer2.Enabled)
                timer2.Enabled = false;
        }

 
    }
}
