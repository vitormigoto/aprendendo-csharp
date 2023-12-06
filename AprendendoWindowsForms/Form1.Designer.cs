namespace AprendendoWindowsForms
{
    partial class frm_inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            this.lbl_display = new System.Windows.Forms.Label();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn_mais = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_vezes = new System.Windows.Forms.Button();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_display
            // 
            resources.ApplyResources(this.lbl_display, "lbl_display");
            this.lbl_display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Click += new System.EventHandler(this.lbl_display_Click);
            // 
            // btn_c
            // 
            resources.ApplyResources(this.btn_c, "btn_c");
            this.btn_c.Name = "btn_c";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_menos
            // 
            resources.ApplyResources(this.btn_menos, "btn_menos");
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.UseVisualStyleBackColor = true;
            this.btn_menos.Click += new System.EventHandler(this.btn_menos_Click);
            // 
            // btn_mais
            // 
            resources.ApplyResources(this.btn_mais, "btn_mais");
            this.btn_mais.Name = "btn_mais";
            this.btn_mais.UseVisualStyleBackColor = true;
            this.btn_mais.Click += new System.EventHandler(this.btn_mais_Click);
            // 
            // btn_dividir
            // 
            resources.ApplyResources(this.btn_dividir, "btn_dividir");
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_vezes
            // 
            resources.ApplyResources(this.btn_vezes, "btn_vezes");
            this.btn_vezes.Name = "btn_vezes";
            this.btn_vezes.UseVisualStyleBackColor = true;
            this.btn_vezes.Click += new System.EventHandler(this.btn_vezes_Click);
            // 
            // txt_num1
            // 
            resources.ApplyResources(this.txt_num1, "txt_num1");
            this.txt_num1.Name = "txt_num1";
            // 
            // txt_num2
            // 
            resources.ApplyResources(this.txt_num2, "txt_num2");
            this.txt_num2.Name = "txt_num2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // frm_inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.btn_vezes);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_mais);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.lbl_display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.Button btn_mais;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_vezes;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

