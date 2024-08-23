namespace TrocaValores
{
    partial class FrmTroca
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
            BtnClicar = new Button();
            LblValor1 = new Label();
            TxtValor = new TextBox();
            LblValor2 = new Label();
            TxtValor2 = new TextBox();
            SuspendLayout();
            // 
            // BtnClicar
            // 
            BtnClicar.Location = new Point(176, 68);
            BtnClicar.Name = "BtnClicar";
            BtnClicar.Size = new Size(75, 23);
            BtnClicar.TabIndex = 0;
            BtnClicar.Text = "Trocar";
            BtnClicar.UseVisualStyleBackColor = true;
            BtnClicar.Click += BtnClick_Click_1;
            // 
            // LblValor1
            // 
            LblValor1.AutoSize = true;
            LblValor1.Location = new Point(11, 17);
            LblValor1.Name = "LblValor1";
            LblValor1.Size = new Size(45, 15);
            LblValor1.TabIndex = 1;
            LblValor1.Text = "Valor 1:";
            // 
            // TxtValor
            // 
            TxtValor.Location = new Point(62, 12);
            TxtValor.Name = "TxtValor";
            TxtValor.Size = new Size(100, 23);
            TxtValor.TabIndex = 5;
            // 
            // LblValor2
            // 
            LblValor2.AutoSize = true;
            LblValor2.Location = new Point(222, 20);
            LblValor2.Name = "LblValor2";
            LblValor2.Size = new Size(45, 15);
            LblValor2.TabIndex = 3;
            LblValor2.Text = "Valor 2:";
            // 
            // TxtValor2
            // 
            TxtValor2.Location = new Point(273, 14);
            TxtValor2.Name = "TxtValor2";
            TxtValor2.Size = new Size(100, 23);
            TxtValor2.TabIndex = 4;
            // 
            // FrmTroca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(427, 105);
            Controls.Add(TxtValor2);
            Controls.Add(LblValor2);
            Controls.Add(TxtValor);
            Controls.Add(LblValor1);
            Controls.Add(BtnClicar);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTroca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Troca de Valores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnClicar;
        private Label LblValor1;
        private TextBox TxtValor;
        private Label LblValor2;
        private TextBox TxtValor2;
    }
}
