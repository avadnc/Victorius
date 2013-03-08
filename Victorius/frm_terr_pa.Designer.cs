namespace Victorius
{
    partial class frm_terr_pa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_terr_pa));
            this.btn_cargar = new System.Windows.Forms.Button();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.txtccaa = new System.Windows.Forms.TextBox();
            this.txtprovincia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(504, 12);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar.TabIndex = 0;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(6, 49);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(155, 20);
            this.txtpais.TabIndex = 1;
            this.txtpais.TextChanged += new System.EventHandler(this.txtpais_TextChanged);
            // 
            // txtccaa
            // 
            this.txtccaa.Location = new System.Drawing.Point(6, 94);
            this.txtccaa.Name = "txtccaa";
            this.txtccaa.Size = new System.Drawing.Size(155, 20);
            this.txtccaa.TabIndex = 2;
            this.txtccaa.TextChanged += new System.EventHandler(this.txtccaa_TextChanged);
            // 
            // txtprovincia
            // 
            this.txtprovincia.Location = new System.Drawing.Point(6, 138);
            this.txtprovincia.Name = "txtprovincia";
            this.txtprovincia.Size = new System.Drawing.Size(155, 20);
            this.txtprovincia.TabIndex = 3;
            this.txtprovincia.TextChanged += new System.EventHandler(this.txtprovincia_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_pais);
            this.groupBox1.Controls.Add(this.txtprovincia);
            this.groupBox1.Controls.Add(this.txtpais);
            this.groupBox1.Controls.Add(this.txtccaa);
            this.groupBox1.Location = new System.Drawing.Point(21, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(6, 30);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(27, 13);
            this.lbl_pais.TabIndex = 4;
            this.lbl_pais.Text = "Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado / Comunidad Autónoma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Provincia";
            // 
            // frm_terr_pa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cargar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_terr_pa";
            this.Text = "Control Territorial";
            this.Load += new System.EventHandler(this.frm_terr_pa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.TextBox txtccaa;
        private System.Windows.Forms.TextBox txtprovincia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pais;
    }
}