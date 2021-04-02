using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoEn
{
    public partial class Stash : Form
    {
        DataTable Headers = new DataTable();
        public Stash()
        {
            InitializeComponent();
            SetDoubleBuffer(dgvStash, true);
        }

        //obsolete now - grid drawing, used datagridview instead
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int cellSize = 20;
            int numOfCells = 24;
            Pen blackPen = new Pen(Color.Black, 3);

            for (int y = 0; y < numOfCells; ++y)
            {
                e.Graphics.DrawLine(blackPen, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                e.Graphics.DrawLine(blackPen, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }
        }

        private void DrawGrid(bool quad)
        {
            int stashFieldsCount; //(144 or 576)

            //setup grid, columns and rows
            if (quad == true)
            {
                stashFieldsCount = 576;
            }
            else
            {
                stashFieldsCount = 144;
            }
           
        }

        private void CreateGrid (DataGridView dgv, bool quad, int xWidth, int yWidth)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            int xCount;
            int yCount;

            if (quad == true) xCount = 24;
            else xCount = 12;

            DataRow dr;
            Headers = new DataTable();
            for (int i = 0; i < xCount; i++)
            {
                Headers.Columns.Add(new DataColumn((i + 1).ToString(), typeof(String)));

            }
            for (int i = 0; i < xCount; i++)
            {
                dr = Headers.NewRow();
                Headers.Rows.Add(dr);
            }
            BindGrid();
            ResizeGrid(25, 25);
            //dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //resizing rows needs to be added
        void ResizeGrid(int columnWidth, int rowHeight)
        {
            foreach (DataGridViewColumn column in dgvStash.Columns)
            {
                column.Width = columnWidth;
            }
        }
        void BindGrid()
        {
            dgvStash.DataSource = Headers;
            dgvStash.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateGrid(dgvStash, true, 25, 25);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateGrid(dgvStash, false, 25, 25);
        }

        //add numbers to row headers
        private void dgvStash_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, ctl, new object[] { DoubleBuffered });
        }
    }
}
