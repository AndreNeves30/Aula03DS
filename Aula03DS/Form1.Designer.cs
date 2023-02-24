
namespace Aula03DS
{
    partial class FormCombinacoes
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
            this.labelTexto = new System.Windows.Forms.Label();
            this.chkGarnet = new System.Windows.Forms.CheckBox();
            this.chkPerola = new System.Windows.Forms.CheckBox();
            this.chkAmetista = new System.Windows.Forms.CheckBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.pictureBoxFormas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTexto
            // 
            this.labelTexto.Location = new System.Drawing.Point(249, 19);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(400, 24);
            this.labelTexto.TabIndex = 0;
            this.labelTexto.Text = "Nenhuma pessoa a vista";
            this.labelTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkGarnet
            // 
            this.chkGarnet.AutoSize = true;
            this.chkGarnet.Location = new System.Drawing.Point(34, 71);
            this.chkGarnet.Name = "chkGarnet";
            this.chkGarnet.Size = new System.Drawing.Size(58, 17);
            this.chkGarnet.TabIndex = 2;
            this.chkGarnet.Text = "Garnet";
            this.chkGarnet.UseVisualStyleBackColor = true;
            this.chkGarnet.CheckedChanged += new System.EventHandler(this.chkGarnet_CheckedChanged);
            // 
            // chkPerola
            // 
            this.chkPerola.AutoSize = true;
            this.chkPerola.Location = new System.Drawing.Point(25, 198);
            this.chkPerola.Name = "chkPerola";
            this.chkPerola.Size = new System.Drawing.Size(56, 17);
            this.chkPerola.TabIndex = 3;
            this.chkPerola.Text = "Perola";
            this.chkPerola.UseVisualStyleBackColor = true;
            this.chkPerola.CheckedChanged += new System.EventHandler(this.chkPerola_CheckedChanged);
            // 
            // chkAmetista
            // 
            this.chkAmetista.AutoSize = true;
            this.chkAmetista.Location = new System.Drawing.Point(25, 334);
            this.chkAmetista.Name = "chkAmetista";
            this.chkAmetista.Size = new System.Drawing.Size(66, 17);
            this.chkAmetista.TabIndex = 4;
            this.chkAmetista.Text = "Ametista";
            this.chkAmetista.UseVisualStyleBackColor = true;
            this.chkAmetista.CheckedChanged += new System.EventHandler(this.chkAmetista_CheckedChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(387, 474);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(117, 13);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "André de Sousa Neves";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxFormas
            // 
            this.pictureBoxFormas.Location = new System.Drawing.Point(252, 46);
            this.pictureBoxFormas.Name = "pictureBoxFormas";
            this.pictureBoxFormas.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxFormas.TabIndex = 1;
            this.pictureBoxFormas.TabStop = false;
            // 
            // FormCombinacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 496);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.chkAmetista);
            this.Controls.Add(this.chkPerola);
            this.Controls.Add(this.chkGarnet);
            this.Controls.Add(this.pictureBoxFormas);
            this.Controls.Add(this.labelTexto);
            this.Name = "FormCombinacoes";
            this.Text = "O programa Combinações";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.PictureBox pictureBoxFormas;
        private System.Windows.Forms.CheckBox chkGarnet;
        private System.Windows.Forms.CheckBox chkPerola;
        private System.Windows.Forms.CheckBox chkAmetista;
        private System.Windows.Forms.Label labelNome;
    }
}

