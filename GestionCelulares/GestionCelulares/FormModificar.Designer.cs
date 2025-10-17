namespace GestionCelulares
{
    partial class FormModificar
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
            Alta = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_stock = new TextBox();
            txt_precio = new TextBox();
            txt_modelo = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // Alta
            // 
            Alta.AutoSize = true;
            Alta.Font = new Font("Segoe UI", 20F);
            Alta.Location = new Point(63, 31);
            Alta.Name = "Alta";
            Alta.Size = new Size(211, 37);
            Alta.TabIndex = 11;
            Alta.Text = "Alta de celulares";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 293);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 255);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 213);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 9;
            label3.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 85);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Marca";
            // 
            // txt_stock
            // 
            txt_stock.Location = new Point(153, 290);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(100, 23);
            txt_stock.TabIndex = 3;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(153, 252);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(100, 23);
            txt_precio.TabIndex = 4;
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(153, 210);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(100, 23);
            txt_modelo.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(153, 84);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 19);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Motorola";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(153, 106);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Samsung";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(153, 128);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(56, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Apple";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(153, 149);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(62, 19);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "Xiaomi";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(153, 170);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(63, 19);
            radioButton5.TabIndex = 12;
            radioButton5.TabStop = true;
            radioButton5.Text = "Huauei";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(125, 369);
            button1.Name = "button1";
            button1.Size = new Size(75, 47);
            button1.TabIndex = 13;
            button1.Text = "Guardar Datos";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 450);
            Controls.Add(button1);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(Alta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_stock);
            Controls.Add(txt_precio);
            Controls.Add(txt_modelo);
            Name = "FormModificar";
            Text = "FormModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Alta;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_stock;
        private TextBox txt_precio;
        private TextBox txt_modelo;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Button button1;
    }
}