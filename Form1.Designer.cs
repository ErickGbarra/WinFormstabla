namespace WinFormstabla
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
            panelprincipal = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            labelnomalu = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = SystemColors.ActiveCaption;
            panelprincipal.Controls.Add(labelnomalu);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(12, 12);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(1003, 487);
            panelprincipal.TabIndex = 0;
            panelprincipal.Paint += panelprincipal_Paint;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Location = new Point(296, 66);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(276, 314);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            richTextBoxresultados.TextChanged += richTextBoxresultados_TextChanged;
            // 
            // buttonver
            // 
            buttonver.BackColor = SystemColors.ActiveBorder;
            buttonver.Location = new Point(85, 234);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(93, 26);
            buttonver.TabIndex = 3;
            buttonver.Text = "Ver tabla";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(58, 133);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(140, 27);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(58, 66);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(140, 16);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cuál tabla quieres?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltitulo.Location = new Point(58, 22);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(170, 20);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla De Multiplicar";
            // 
            // labelnomalu
            // 
            labelnomalu.AutoSize = true;
            labelnomalu.Location = new Point(58, 413);
            labelnomalu.Name = "labelnomalu";
            labelnomalu.Size = new Size(196, 40);
            labelnomalu.TabIndex = 5;
            labelnomalu.Text = "Erick Mauricio Gomez Ibarra\r\nID: 270014";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 511);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private TextBox textBoxnum;
        private Label labelnumero;
        private Label labeltitulo;
        private RichTextBox richTextBoxresultados;
        private Button buttonver;
        private Label labelnomalu;
    }
}
