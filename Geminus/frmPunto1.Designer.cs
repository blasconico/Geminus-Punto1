namespace Geminus
{
    partial class frmPunto1
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
            this.lblCasillas = new System.Windows.Forms.Label();
            this.txtCasillas = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTablero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCasillas
            // 
            this.lblCasillas.AutoSize = true;
            this.lblCasillas.Location = new System.Drawing.Point(27, 33);
            this.lblCasillas.Name = "lblCasillas";
            this.lblCasillas.Size = new System.Drawing.Size(46, 15);
            this.lblCasillas.TabIndex = 0;
            this.lblCasillas.Text = "Casillas";
            // 
            // txtCasillas
            // 
            this.txtCasillas.Location = new System.Drawing.Point(86, 29);
            this.txtCasillas.Name = "txtCasillas";
            this.txtCasillas.Size = new System.Drawing.Size(100, 23);
            this.txtCasillas.TabIndex = 1;
            this.txtCasillas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCasillas_KeyPress);
            this.txtCasillas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCasillas_KeyUp);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(202, 29);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTablero
            // 
            this.txtTablero.Location = new System.Drawing.Point(27, 73);
            this.txtTablero.Multiline = true;
            this.txtTablero.Name = "txtTablero";
            this.txtTablero.Size = new System.Drawing.Size(250, 221);
            this.txtTablero.TabIndex = 3;
            // 
            // frmPunto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 306);
            this.Controls.Add(this.txtTablero);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCasillas);
            this.Controls.Add(this.lblCasillas);
            this.Name = "frmPunto1";
            this.Text = "Punto 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCasillas;
        private TextBox txtCasillas;
        private Button btnReset;
        private TextBox txtTablero;
    }
}