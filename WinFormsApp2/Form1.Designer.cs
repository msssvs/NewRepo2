namespace WinFormsApp2
{
    partial class frmMass
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtn = new TextBox();
            txtm = new TextBox();
            txtRez = new TextBox();
            dgvMass = new DataGridView();
            cmdStart = new Button();
            cmdExit = new Button();
            cmdClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 0;
            label1.Text = "Количество строк n=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 1;
            label2.Text = "Количество строк m=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 2;
            label3.Text = "Результат:";
            // 
            // txtn
            // 
            txtn.Location = new Point(12, 53);
            txtn.Name = "txtn";
            txtn.Size = new Size(161, 29);
            txtn.TabIndex = 3;
            // 
            // txtm
            // 
            txtm.Location = new Point(12, 129);
            txtm.Name = "txtm";
            txtm.Size = new Size(161, 29);
            txtm.TabIndex = 4;
            // 
            // txtRez
            // 
            txtRez.Location = new Point(12, 209);
            txtRez.Multiline = true;
            txtRez.Name = "txtRez";
            txtRez.Size = new Size(372, 290);
            txtRez.TabIndex = 5;
            // 
            // dgvMass
            // 
            dgvMass.AllowUserToOrderColumns = true;
            dgvMass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMass.Location = new Point(401, 20);
            dgvMass.Name = "dgvMass";
            dgvMass.Size = new Size(606, 479);
            dgvMass.TabIndex = 6;
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(12, 519);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(197, 35);
            cmdStart.TabIndex = 7;
            cmdStart.Text = "Вычислить";
            cmdStart.UseVisualStyleBackColor = true;
            cmdStart.Click += cmdStart_Click;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(713, 519);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(294, 35);
            cmdExit.TabIndex = 8;
            cmdExit.Text = "Завершить работу";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(282, 519);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(326, 35);
            cmdClear.TabIndex = 9;
            cmdClear.Text = "Очистка полей";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // frmMass
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 589);
            Controls.Add(cmdClear);
            Controls.Add(cmdExit);
            Controls.Add(cmdStart);
            Controls.Add(dgvMass);
            Controls.Add(txtRez);
            Controls.Add(txtm);
            Controls.Add(txtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmMass";
            Text = "Двумерные массивы";
            Load += frmMass_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtn;
        private TextBox txtm;
        private TextBox txtRez;
        private DataGridView dgvMass;
        private Button cmdStart;
        private Button cmdExit;
        private Button cmdClear;
    }
}
