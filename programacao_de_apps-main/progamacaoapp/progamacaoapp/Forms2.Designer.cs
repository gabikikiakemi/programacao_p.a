namespace progamacaoapp
{
    partial class Forms2
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
            btnExcel = new Button();
            btnpdf = new Button();
            btngrafico = new Button();
            SuspendLayout();
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.HotPink;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Location = new Point(58, 52);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(94, 29);
            btnExcel.TabIndex = 0;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += button1_Click;
            // 
            // btnpdf
            // 
            btnpdf.BackColor = Color.HotPink;
            btnpdf.FlatStyle = FlatStyle.Flat;
            btnpdf.Location = new Point(192, 52);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(94, 29);
            btnpdf.TabIndex = 1;
            btnpdf.Text = "Gerar PDF";
            btnpdf.UseVisualStyleBackColor = false;
            // 
            // btngrafico
            // 
            btngrafico.BackColor = Color.HotPink;
            btngrafico.FlatStyle = FlatStyle.Flat;
            btngrafico.Location = new Point(322, 52);
            btngrafico.Name = "btngrafico";
            btngrafico.Size = new Size(129, 29);
            btngrafico.TabIndex = 2;
            btngrafico.Text = "Gerar Gráfico";
            btngrafico.UseVisualStyleBackColor = false;
            // 
            // Forms2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btngrafico);
            Controls.Add(btnpdf);
            Controls.Add(btnExcel);
            Name = "Forms2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExcel;
        private Button btnpdf;
        private Button btngrafico;
    }
}