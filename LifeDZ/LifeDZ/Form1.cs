using System;
using System.Windows.Forms;



namespace LifeDZ
{
    public partial class Form1 : Form
    {
        private int n;
        private Style celColor = new Style();
        private Game game;
        private int _ticks_2;
        private int CellClick = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void resizeGrid()
        {
            if (n != 0)
            {
                int size = dataGridView1.Width > dataGridView1.Height ? dataGridView1.Height : dataGridView1.Width;
                size -= 10;
                size /= n;
                for (int i = 0; i < n; i++)
                {
                    dataGridView1.Columns[i].Width = size;
                    dataGridView1.Rows[i].Height = size;
                }
            }
        }

        void show()
        {
            int[,] area = game.Area;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (area[j, i] == 50)
                        dataGridView1[i, j].Style.BackColor = celColor.Life;
                    if (area[j, i] == 0)
                        dataGridView1[i, j].Style.BackColor = celColor.TerraIncognita;
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            button4.Visible = false;
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
             
            if (dataGridView1[col, row].Style.BackColor != celColor.Life && CellClick != trackBar2.Minimum)
                if (CellClick <= trackBar2.Minimum)
                {
                    dataGridView1[col, row].Style.BackColor = celColor.Life;
                }
                else if ((trackBar2.Maximum >= CellClick) && (button2.Visible == true) && (CellClick >= trackBar2.Minimum))
                {
                    trackBar2.Value = CellClick;
                    dataGridView1[col, row].Style.BackColor = celColor.Life;
                }
            game.search_for_life(col, row);
            CellClick = game.Life_count();
            label2.Text = CellClick.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            n = trackBar1.Value;
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = n;
            resizeGrid();
            dataGridView1.DefaultCellStyle.BackColor = celColor.TerraIncognita;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = celColor.TerraIncognita;
            game = new Game(n);
            show();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (CellClick < trackBar2.Minimum)
                MessageBox.Show("Необходимо разместить минимум 4 клетки");
            if ((dataGridView1.ColumnCount != 0) && (
            dataGridView1.RowCount != 0) && (CellClick >= trackBar2.Minimum))
            {
                timer2.Start();
                button2.Visible = false;
                button1.Visible = false;
                button4.Visible = false;
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            _ticks_2++;
            label5.Text = _ticks_2.ToString();
            game.search_for_life();
            show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible =  true;
            button4.Visible = true;
            timer2.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
            button4.Visible = false;
            _ticks_2 = 0;
            label5.Text = _ticks_2.ToString();
        }
    }
}
