namespace AplicacionFormularios
{
    partial class FormSecundario
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
            txt_mostrarDatos = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_mostrarDatos
            // 
            txt_mostrarDatos.Location = new Point(269, 73);
            txt_mostrarDatos.Name = "txt_mostrarDatos";
            txt_mostrarDatos.Size = new Size(288, 23);
            txt_mostrarDatos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(345, 165);
            button1.Name = "button1";
            button1.Size = new Size(107, 85);
            button1.TabIndex = 1;
            button1.Text = "Volver a formulario principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormSecundario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txt_mostrarDatos);
            Name = "FormSecundario";
            Text = "FormSecundario";
            Load += FormSecundario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_mostrarDatos;
        private Button button1;
    }
}