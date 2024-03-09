namespace registro_personas_gui_01_5_2_24
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
            lbl_Nombre=new Label();
            lbl_Edad=new Label();
            txt_Nombre=new TextBox();
            txt_Edad=new TextBox();
            btn_Nuevo=new Button();
            btn_Guardar=new Button();
            btn_Editar=new Button();
            btn_Eliminar=new Button();
            btn_Salir=new Button();
            SuspendLayout();
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize=true;
            lbl_Nombre.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.Location=new Point(205, 131);
            lbl_Nombre.Name="lbl_Nombre";
            lbl_Nombre.Size=new Size(63, 19);
            lbl_Nombre.TabIndex=0;
            lbl_Nombre.Text="Nombre";
            // 
            // lbl_Edad
            // 
            lbl_Edad.AutoSize=true;
            lbl_Edad.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Edad.Location=new Point(205, 189);
            lbl_Edad.Name="lbl_Edad";
            lbl_Edad.Size=new Size(43, 19);
            lbl_Edad.TabIndex=1;
            lbl_Edad.Text="Edad";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location=new Point(396, 121);
            txt_Nombre.Name="txt_Nombre";
            txt_Nombre.Size=new Size(295, 23);
            txt_Nombre.TabIndex=2;
            // 
            // txt_Edad
            // 
            txt_Edad.Location=new Point(396, 181);
            txt_Edad.Name="txt_Edad";
            txt_Edad.Size=new Size(100, 23);
            txt_Edad.TabIndex=3;
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Nuevo.Location=new Point(187, 314);
            btn_Nuevo.Name="btn_Nuevo";
            btn_Nuevo.Size=new Size(75, 23);
            btn_Nuevo.TabIndex=4;
            btn_Nuevo.Text="Nuevo";
            btn_Nuevo.UseVisualStyleBackColor=true;
            btn_Nuevo.Click+=btn_Nuevo_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Guardar.Location=new Point(277, 314);
            btn_Guardar.Name="btn_Guardar";
            btn_Guardar.Size=new Size(75, 23);
            btn_Guardar.TabIndex=5;
            btn_Guardar.Text="Guardar";
            btn_Guardar.UseVisualStyleBackColor=true;
            btn_Guardar.Click+=btn_Guardar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Editar.Location=new Point(376, 314);
            btn_Editar.Name="btn_Editar";
            btn_Editar.Size=new Size(75, 23);
            btn_Editar.TabIndex=6;
            btn_Editar.Text="Editar";
            btn_Editar.UseVisualStyleBackColor=true;
            btn_Editar.Click+=btn_Editar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.Location=new Point(473, 314);
            btn_Eliminar.Name="btn_Eliminar";
            btn_Eliminar.Size=new Size(75, 23);
            btn_Eliminar.TabIndex=7;
            btn_Eliminar.Text="Eliminar";
            btn_Eliminar.UseVisualStyleBackColor=true;
            btn_Eliminar.Click+=btn_Eliminar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font=new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location=new Point(572, 314);
            btn_Salir.Name="btn_Salir";
            btn_Salir.Size=new Size(75, 23);
            btn_Salir.TabIndex=8;
            btn_Salir.Text="Salir";
            btn_Salir.UseVisualStyleBackColor=true;
            btn_Salir.Click+=btn_Salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Guardar);
            Controls.Add(btn_Nuevo);
            Controls.Add(txt_Edad);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_Edad);
            Controls.Add(lbl_Nombre);
            Name="Form1";
            Text="Registro de personas";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nombre;
        private Label lbl_Edad;
        private TextBox txt_Nombre;
        private TextBox txt_Edad;
        private Button btn_Nuevo;
        private Button btn_Guardar;
        private Button btn_Editar;
        private Button btn_Eliminar;
        private Button btn_Salir;
    }
}