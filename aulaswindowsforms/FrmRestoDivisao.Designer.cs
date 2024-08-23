namespace aulaswindowsforms
{
    partial class FrmRestoDivisao
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
            lbldividendo = new Label();
            txtdividendo = new TextBox();
            btnrestodadivisao = new Button();
            lblDivisor = new Label();
            lblResto = new Label();
            txtresto = new TextBox();
            txtdivisor = new TextBox();
            SuspendLayout();
            // 
            // lbldividendo
            // 
            lbldividendo.AutoSize = true;
            lbldividendo.Location = new Point(35, 54);
            lbldividendo.Name = "lbldividendo";
            lbldividendo.Size = new Size(60, 15);
            lbldividendo.TabIndex = 0;
            lbldividendo.Text = "dividendo";
            lbldividendo.Click += label1_Click;
            // 
            // txtdividendo
            // 
            txtdividendo.Location = new Point(101, 50);
            txtdividendo.Name = "txtdividendo";
            txtdividendo.Size = new Size(100, 23);
            txtdividendo.TabIndex = 1;
            txtdividendo.TextChanged += txtBox1_TextChanged;
            // 
            // btnrestodadivisao
            // 
            btnrestodadivisao.Location = new Point(68, 219);
            btnrestodadivisao.Name = "btnrestodadivisao";
            btnrestodadivisao.Size = new Size(168, 23);
            btnrestodadivisao.TabIndex = 2;
            btnrestodadivisao.Text = "resto da divisao";
            btnrestodadivisao.UseVisualStyleBackColor = true;
            btnrestodadivisao.Click += btn_Click;
            // 
            // lblDivisor
            // 
            lblDivisor.AutoSize = true;
            lblDivisor.Location = new Point(358, 54);
            lblDivisor.Name = "lblDivisor";
            lblDivisor.Size = new Size(46, 15);
            lblDivisor.TabIndex = 4;
            lblDivisor.Text = "Divisor:";
            lblDivisor.Click += label3_Click;
            // 
            // lblResto
            // 
            lblResto.AutoSize = true;
            lblResto.Location = new Point(371, 227);
            lblResto.Name = "lblResto";
            lblResto.Size = new Size(33, 15);
            lblResto.TabIndex = 5;
            lblResto.Text = "resto";
            // 
            // txtresto
            // 
            txtresto.Location = new Point(426, 219);
            txtresto.Name = "txtresto";
            txtresto.ReadOnly = true;
            txtresto.Size = new Size(100, 23);
            txtresto.TabIndex = 6;
            // 
            // txtdivisor
            // 
            txtdivisor.Location = new Point(426, 54);
            txtdivisor.Name = "txtdivisor";
            txtdivisor.Size = new Size(100, 23);
            txtdivisor.TabIndex = 6;
            // 
            // FrmRestoDivisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 450);
            Controls.Add(txtdivisor);
            Controls.Add(txtresto);
            Controls.Add(lblResto);
            Controls.Add(lblDivisor);
            Controls.Add(btnrestodadivisao);
            Controls.Add(txtdividendo);
            Controls.Add(lbldividendo);
            Name = "FrmRestoDivisao";
            Text = "FrmRestoDivisao";
            Load += FrmRestoDivisao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldividendo;
        private TextBox txtdividendo;
        private Button btnrestodadivisao;
        private Label lblDivisor;
        private Label lblResto;
        private TextBox txtresto;
        private TextBox txtdivisor;
    }
}