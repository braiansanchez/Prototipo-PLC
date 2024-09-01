namespace Modulo_Prototipo_PLC
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(168, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(854, 888);
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
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 12;
            Column3.Name = "Column3";
            Column3.Width = 250;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.Location = new Point(1554, 74);
            button4.Name = "button4";
            button4.Size = new Size(319, 58);
            button4.TabIndex = 8;
            button4.Text = "Cambiar pantalla 1";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(684, 74);
            button2.Name = "button2";
            button2.Size = new Size(197, 58);
            button2.TabIndex = 10;
            button2.Text = "Desconectar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(273, 74);
            button1.Name = "button1";
            button1.Size = new Size(196, 58);
            button1.TabIndex = 9;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1942, 1135);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Pantalla 2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button4;
        private Button button2;
        private Button button1;
    }
}