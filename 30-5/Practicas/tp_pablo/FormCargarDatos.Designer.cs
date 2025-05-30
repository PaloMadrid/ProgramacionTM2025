namespace Repaso_Formularios
{
    partial class FormCargarDatos
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
            btn_cargar = new Button();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            lbl_mostrarNombre = new Label();
            lbl_edad = new Label();
            txt_edad = new TextBox();
            cmb_genero = new ComboBox();
            lbl_genero = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_cargar
            // 
            btn_cargar.Location = new Point(293, 286);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(75, 55);
            btn_cargar.TabIndex = 4;
            btn_cargar.Text = "Guardar datos";
            btn_cargar.UseVisualStyleBackColor = true;
            btn_cargar.Click += btn_cargar_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.BackColor = SystemColors.ActiveCaption;
            lbl_nombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombre.ForeColor = SystemColors.HotTrack;
            lbl_nombre.Location = new Point(72, 75);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(71, 21);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(149, 75);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(121, 23);
            txt_nombre.TabIndex = 1;
            // 
            // lbl_mostrarNombre
            // 
            lbl_mostrarNombre.AutoSize = true;
            lbl_mostrarNombre.BackColor = Color.Plum;
            lbl_mostrarNombre.Location = new Point(539, 81);
            lbl_mostrarNombre.Name = "lbl_mostrarNombre";
            lbl_mostrarNombre.Size = new Size(37, 15);
            lbl_mostrarNombre.TabIndex = 4;
            lbl_mostrarNombre.Text = "Datos";
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.BackColor = SystemColors.ActiveCaption;
            lbl_edad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_edad.ForeColor = SystemColors.HotTrack;
            lbl_edad.Location = new Point(72, 117);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(47, 21);
            lbl_edad.TabIndex = 1;
            lbl_edad.Text = "Edad:";
            // 
            // txt_edad
            // 
            txt_edad.Location = new Point(149, 117);
            txt_edad.Name = "txt_edad";
            txt_edad.Size = new Size(121, 23);
            txt_edad.TabIndex = 2;
            // 
            // cmb_genero
            // 
            cmb_genero.FormattingEnabled = true;
            cmb_genero.Items.AddRange(new object[] { "Femenino", "Masculino", "No binario" });
            cmb_genero.Location = new Point(149, 155);
            cmb_genero.Name = "cmb_genero";
            cmb_genero.Size = new Size(121, 23);
            cmb_genero.TabIndex = 3;
            // 
            // lbl_genero
            // 
            lbl_genero.AutoSize = true;
            lbl_genero.BackColor = SystemColors.ActiveCaption;
            lbl_genero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_genero.ForeColor = SystemColors.HotTrack;
            lbl_genero.Location = new Point(72, 157);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(64, 21);
            lbl_genero.TabIndex = 1;
            lbl_genero.Text = "Genero:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 99);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "textbox";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 158);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 7;
            label2.Text = "combobox";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 306);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "button";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 51);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "label";
            // 
            // FormCargarDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 368);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb_genero);
            Controls.Add(lbl_mostrarNombre);
            Controls.Add(txt_edad);
            Controls.Add(lbl_genero);
            Controls.Add(lbl_edad);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_nombre);
            Controls.Add(btn_cargar);
            Name = "FormCargarDatos";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cargar;
        private Label lbl_nombre;
        private TextBox txt_nombre;
        private Label lbl_mostrarNombre;
        private Label lbl_edad;
        private TextBox txt_edad;
        private ComboBox cmb_genero;
        private Label lbl_genero;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}
