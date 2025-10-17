namespace GestionCelulares
{
    partial class FormAlta
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
            txt_marca = new TextBox();
            txt_modelo = new TextBox();
            txt_precio = new TextBox();
            txt_stock = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Alta = new Label();
            btn_alta = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(139, 128);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(100, 23);
            txt_marca.TabIndex = 0;
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(139, 166);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(100, 23);
            txt_modelo.TabIndex = 0;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(139, 208);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(100, 23);
            txt_precio.TabIndex = 0;
            // 
            // txt_stock
            // 
            txt_stock.Location = new Point(139, 246);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(100, 23);
            txt_stock.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 131);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 169);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 1;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 211);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 1;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 249);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 1;
            label5.Text = "Stock";
            // 
            // Alta
            // 
            Alta.AutoSize = true;
            Alta.Font = new Font("Segoe UI", 20F);
            Alta.Location = new Point(45, 25);
            Alta.Name = "Alta";
            Alta.Size = new Size(211, 37);
            Alta.TabIndex = 2;
            Alta.Text = "Alta de celulares";
            Alta.Click += Alta_Click;
            // 
            // btn_alta
            // 
            btn_alta.Location = new Point(153, 309);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(75, 61);
            btn_alta.TabIndex = 3;
            btn_alta.Text = "Cargar Celular";
            btn_alta.UseVisualStyleBackColor = true;
            btn_alta.Click += btn_alta_Click;
            // 
            // button1
            // 
            button1.Location = new Point(59, 309);
            button1.Name = "button1";
            button1.Size = new Size(75, 61);
            button1.TabIndex = 4;
            button1.Text = "Ver celulares";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 450);
            Controls.Add(button1);
            Controls.Add(btn_alta);
            Controls.Add(Alta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_stock);
            Controls.Add(txt_precio);
            Controls.Add(txt_modelo);
            Controls.Add(txt_marca);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_marca;
        private TextBox txt_modelo;
        private TextBox txt_precio;
        private TextBox txt_stock;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Alta;
        private Button btn_alta;
        private Button button1;
    }
}
