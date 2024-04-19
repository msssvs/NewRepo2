namespace WinFormsApp2
{
    public partial class frmMass : Form
    {
        public frmMass()
        {
            InitializeComponent();
        }

        private void frmMass_Load(object sender, EventArgs e)
        {

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtm.Text = "";
            txtm.Text = "";
            txtRez.Text = "";
            dgvMass.Rows.Clear();
            dgvMass.Columns.Clear();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            int n, m, nn = 0;
            float summ = 0, sr = 0;
            n = Int32.Parse(txtm.Text);
            m = Int32.Parse(txtm.Text);
            int[,] A = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    A[i, j] = rnd.Next(-50, 50);
                }
            }
            dgvMass.RowCount = n;
            dgvMass.ColumnCount = m;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    dgvMass.Rows[i].Cells[j].Value = A[i, j];
                }
            }
            for (int j = 0; j <= m - 1; j++)
                dgvMass.Columns[j].Width = 50;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    if (A[i, j] > 0)
                    {
                        summ = summ + A[i, j];
                        nn += 1;
                    }
                }
            }
            sr = summ / nn;
            txtRez.Text = "Среднее арифметическое =" + Math.Round(sr, 5).ToString() + Environment.NewLine + "Количество положительных элементов = " + nn.ToString();

      }
    }
}

