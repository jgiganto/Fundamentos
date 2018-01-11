namespace Fundamentos
{
    partial class Form20TiendadeProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtentradaproducto = new System.Windows.Forms.TextBox();
            this.lstproductostienda = new System.Windows.Forms.ListBox();
            this.lstalmacen = new System.Windows.Forms.ListBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnborrartienda = new System.Windows.Forms.Button();
            this.btnsubirpos = new System.Windows.Forms.Button();
            this.btnbajarpos = new System.Windows.Forms.Button();
            this.btnmoversel = new System.Windows.Forms.Button();
            this.btnmovertodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // txtentradaproducto
            // 
            this.txtentradaproducto.Location = new System.Drawing.Point(123, 43);
            this.txtentradaproducto.Name = "txtentradaproducto";
            this.txtentradaproducto.Size = new System.Drawing.Size(122, 24);
            this.txtentradaproducto.TabIndex = 1;
            // 
            // lstproductostienda
            // 
            this.lstproductostienda.FormattingEnabled = true;
            this.lstproductostienda.ItemHeight = 18;
            this.lstproductostienda.Location = new System.Drawing.Point(154, 138);
            this.lstproductostienda.Name = "lstproductostienda";
            this.lstproductostienda.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstproductostienda.Size = new System.Drawing.Size(199, 346);
            this.lstproductostienda.TabIndex = 2;
            // 
            // lstalmacen
            // 
            this.lstalmacen.FormattingEnabled = true;
            this.lstalmacen.ItemHeight = 18;
            this.lstalmacen.Location = new System.Drawing.Point(494, 138);
            this.lstalmacen.Name = "lstalmacen";
            this.lstalmacen.Size = new System.Drawing.Size(199, 346);
            this.lstalmacen.TabIndex = 3;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(26, 138);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(103, 43);
            this.btnnuevo.TabIndex = 4;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(26, 224);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(103, 43);
            this.btnmodificar.TabIndex = 5;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(26, 306);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(103, 43);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnborrartienda
            // 
            this.btnborrartienda.Location = new System.Drawing.Point(26, 390);
            this.btnborrartienda.Name = "btnborrartienda";
            this.btnborrartienda.Size = new System.Drawing.Size(103, 77);
            this.btnborrartienda.TabIndex = 7;
            this.btnborrartienda.Text = "Borrar tienda";
            this.btnborrartienda.UseVisualStyleBackColor = true;
            this.btnborrartienda.Click += new System.EventHandler(this.btnborrartienda_Click);
            // 
            // btnsubirpos
            // 
            this.btnsubirpos.Location = new System.Drawing.Point(320, 12);
            this.btnsubirpos.Name = "btnsubirpos";
            this.btnsubirpos.Size = new System.Drawing.Size(172, 33);
            this.btnsubirpos.TabIndex = 8;
            this.btnsubirpos.Text = "Subir posición";
            this.btnsubirpos.UseVisualStyleBackColor = true;
            // 
            // btnbajarpos
            // 
            this.btnbajarpos.Location = new System.Drawing.Point(320, 63);
            this.btnbajarpos.Name = "btnbajarpos";
            this.btnbajarpos.Size = new System.Drawing.Size(172, 33);
            this.btnbajarpos.TabIndex = 9;
            this.btnbajarpos.Text = "Bajar posición";
            this.btnbajarpos.UseVisualStyleBackColor = true;
            // 
            // btnmoversel
            // 
            this.btnmoversel.Location = new System.Drawing.Point(375, 191);
            this.btnmoversel.Name = "btnmoversel";
            this.btnmoversel.Size = new System.Drawing.Size(94, 76);
            this.btnmoversel.TabIndex = 10;
            this.btnmoversel.Text = "Mover selección";
            this.btnmoversel.UseVisualStyleBackColor = true;
            // 
            // btnmovertodos
            // 
            this.btnmovertodos.Location = new System.Drawing.Point(375, 289);
            this.btnmovertodos.Name = "btnmovertodos";
            this.btnmovertodos.Size = new System.Drawing.Size(94, 76);
            this.btnmovertodos.TabIndex = 11;
            this.btnmovertodos.Text = "Mover todos";
            this.btnmovertodos.UseVisualStyleBackColor = true;
            // 
            // Form20TiendadeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 569);
            this.Controls.Add(this.btnmovertodos);
            this.Controls.Add(this.btnmoversel);
            this.Controls.Add(this.btnbajarpos);
            this.Controls.Add(this.btnsubirpos);
            this.Controls.Add(this.btnborrartienda);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.lstalmacen);
            this.Controls.Add(this.lstproductostienda);
            this.Controls.Add(this.txtentradaproducto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form20TiendadeProductos";
            this.Text = "Form20TiendadeProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtentradaproducto;
        private System.Windows.Forms.ListBox lstproductostienda;
        private System.Windows.Forms.ListBox lstalmacen;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnborrartienda;
        private System.Windows.Forms.Button btnsubirpos;
        private System.Windows.Forms.Button btnbajarpos;
        private System.Windows.Forms.Button btnmoversel;
        private System.Windows.Forms.Button btnmovertodos;
    }
}