namespace AplicacionFormularios
{
    partial class FormInicio
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
            txt_nombre = new TextBox();
            label2 = new Label();
            txt_apellido = new TextBox();
            label3 = new Label();
            num_edad = new NumericUpDown();
            btn_cargarInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)num_edad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 63);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(241, 63);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 109);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Apellido";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(241, 109);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(100, 23);
            txt_apellido.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 163);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 0;
            label3.Text = "Edad";
            // 
            // num_edad
            // 
            num_edad.Location = new Point(241, 162);
            num_edad.Name = "num_edad";
            num_edad.Size = new Size(120, 23);
            num_edad.TabIndex = 2;
            // 
            // btn_cargarInfo
            // 
            btn_cargarInfo.Location = new Point(463, 81);
            btn_cargarInfo.Name = "btn_cargarInfo";
            btn_cargarInfo.Size = new Size(75, 76);
            btn_cargarInfo.TabIndex = 3;
            btn_cargarInfo.Text = "Ir a formulario secundario";
            btn_cargarInfo.UseVisualStyleBackColor = true;
            btn_cargarInfo.Click += btn_cargarInfo_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cargarInfo);
            Controls.Add(num_edad);
            Controls.Add(txt_apellido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Name = "FormInicio";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)num_edad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nombre;
        private Label label2;
        private TextBox txt_apellido;
        private Label label3;
        private NumericUpDown num_edad;
        private Button btn_cargarInfo;
    }
}
