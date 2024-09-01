namespace Modulo_Prototipo_PLC
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnConnect = new Button();
            btnDisconnect = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(161, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(608, 829);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 12;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 12;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(161, 73);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(196, 58);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(572, 73);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(197, 58);
            btnDisconnect.TabIndex = 2;
            btnDisconnect.Text = "Desconectar";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(976, 381);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 47);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(976, 483);
            button3.Name = "button3";
            button3.Size = new Size(188, 58);
            button3.TabIndex = 4;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(980, 289);
            label1.Name = "label1";
            label1.Size = new Size(171, 41);
            label1.TabIndex = 5;
            label1.Text = "Valor actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(1192, 288);
            label2.Name = "label2";
            label2.Size = new Size(66, 41);
            label2.TabIndex = 6;
            label2.Text = "null";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.Location = new Point(1445, 73);
            button4.Name = "button4";
            button4.Size = new Size(319, 58);
            button4.TabIndex = 7;
            button4.Text = "Cambiar pantalla 2";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 1058);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Pantalla 1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnConnect;
        private Button btnDisconnect;
        private TextBox textBox1;
        private Button button3;
        private Label label1;
        private Label label2;
        private Button button4;
    }
}