namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string firstPlayer, seconedPlayer;
        int i = 1;
        int j = 2;
        int k = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void click(Label sender) {
            if (i % 2 == 0)
            {
                sender.Text = seconedPlayer;
                sender.BackColor = Color.Red;
                i++;
                solotion();
            }
            else
            {
                sender.Text = firstPlayer;
                sender.BackColor = Color.Blue;
                i++;
                solotion();
            }
        }
        private void res(Label sender) {
            sender.Text = k.ToString();
            sender.BackColor =this.BackColor;
            k++;
        }
        string name;
        private void solotion() { 
            if (label1.Text == label2.Text && label1.Text == label3.Text && label1.Text!=null)
                MessageBox.Show("the wener is "+label1.Text);
            if (label1.Text == label4.Text && label1.Text == label7.Text && label1.Text != null)
                MessageBox.Show("the wener is " + label1.Text);
            if (label4.Text == label5.Text && label4.Text == label6.Text && label4.Text != null)
                MessageBox.Show("the wener is " + label15.Text);
            if (label2.Text == label5.Text && label5.Text == label8.Text && label2.Text != null)
                MessageBox.Show("the wener is " + label2.Text);
            if (label7.Text == label9.Text && label7.Text == label8.Text && label8.Text != null)
                MessageBox.Show("the wener is " + label7.Text);
            if (label9.Text == label3.Text && label9.Text == label6.Text && label6.Text != null)
                MessageBox.Show("the wener is " + label9.Text);
            if (label9.Text == label1.Text && label9.Text == label5.Text && label5.Text != null)
                MessageBox.Show("the wener is " + label9.Text);
            if (label3.Text == label5.Text && label5.Text == label7.Text && label7.Text != null)
                MessageBox.Show("the wener is " + label5.Text);
        }
        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            click(label7);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            seconedPlayer = textBox2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            click(label1);

        }

        private void label4_Click(object sender, EventArgs e)
        {
            click(label4);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            click(label2);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            click(label3);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            click(label5);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            click(label6);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            click(label8);

        }

        private void label9_Click(object sender, EventArgs e)
        {
            click(label9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(j%2==0)
            {
                MessageBox.Show("wellcome "+firstPlayer+" and "+seconedPlayer);
                button1.Text = "reset";
                j++;

            }
            else
            {
                res(label1);
                res(label2);
                res(label3);
                res(label4);
                res(label5);
                res(label6);
                res(label7);
                res(label8);
                res(label9);
                k = 1;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstPlayer = textBox1.Text;
        }
    }
}