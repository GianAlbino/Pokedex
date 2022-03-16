
namespace Pokedex
{
    partial class DetalhesPokemon
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
            this.img_pokemon = new System.Windows.Forms.PictureBox();
            this.lbl_nomePokemon = new System.Windows.Forms.Label();
            this.btn_status = new System.Windows.Forms.Button();
            this.btn_tipo = new System.Windows.Forms.Button();
            this.txtbox_detalhes = new System.Windows.Forms.TextBox();
            this.btn_experienciaBase = new System.Windows.Forms.Button();
            this.btn_movimentos = new System.Windows.Forms.Button();
            this.btn_habilidades = new System.Windows.Forms.Button();
            this.btn_localizacao = new System.Windows.Forms.Button();
            this.btn_altura = new System.Windows.Forms.Button();
            this.btn_peso = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_pokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // img_pokemon
            // 
            this.img_pokemon.Location = new System.Drawing.Point(12, 117);
            this.img_pokemon.Name = "img_pokemon";
            this.img_pokemon.Size = new System.Drawing.Size(200, 200);
            this.img_pokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_pokemon.TabIndex = 6;
            this.img_pokemon.TabStop = false;
            // 
            // lbl_nomePokemon
            // 
            this.lbl_nomePokemon.AutoSize = true;
            this.lbl_nomePokemon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomePokemon.Location = new System.Drawing.Point(12, 32);
            this.lbl_nomePokemon.Name = "lbl_nomePokemon";
            this.lbl_nomePokemon.Size = new System.Drawing.Size(185, 32);
            this.lbl_nomePokemon.TabIndex = 5;
            this.lbl_nomePokemon.Text = "pokemon nome";
            // 
            // btn_status
            // 
            this.btn_status.Location = new System.Drawing.Point(324, 99);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(100, 50);
            this.btn_status.TabIndex = 8;
            this.btn_status.Text = "Status";
            this.btn_status.UseVisualStyleBackColor = true;
            this.btn_status.Click += new System.EventHandler(this.Btn_status_Click);
            // 
            // btn_tipo
            // 
            this.btn_tipo.Location = new System.Drawing.Point(218, 99);
            this.btn_tipo.Name = "btn_tipo";
            this.btn_tipo.Size = new System.Drawing.Size(100, 50);
            this.btn_tipo.TabIndex = 7;
            this.btn_tipo.Text = "Tipo";
            this.btn_tipo.UseVisualStyleBackColor = true;
            this.btn_tipo.Click += new System.EventHandler(this.Btn_tipo_Click);
            // 
            // txtbox_detalhes
            // 
            this.txtbox_detalhes.Location = new System.Drawing.Point(430, 41);
            this.txtbox_detalhes.Multiline = true;
            this.txtbox_detalhes.Name = "txtbox_detalhes";
            this.txtbox_detalhes.ReadOnly = true;
            this.txtbox_detalhes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_detalhes.Size = new System.Drawing.Size(235, 276);
            this.txtbox_detalhes.TabIndex = 10;
            // 
            // btn_experienciaBase
            // 
            this.btn_experienciaBase.Location = new System.Drawing.Point(324, 155);
            this.btn_experienciaBase.Name = "btn_experienciaBase";
            this.btn_experienciaBase.Size = new System.Drawing.Size(100, 50);
            this.btn_experienciaBase.TabIndex = 15;
            this.btn_experienciaBase.Text = "Experiência Base";
            this.btn_experienciaBase.UseVisualStyleBackColor = true;
            this.btn_experienciaBase.Click += new System.EventHandler(this.Btn_experienciaBase_Click);
            // 
            // btn_movimentos
            // 
            this.btn_movimentos.Location = new System.Drawing.Point(218, 155);
            this.btn_movimentos.Name = "btn_movimentos";
            this.btn_movimentos.Size = new System.Drawing.Size(100, 50);
            this.btn_movimentos.TabIndex = 14;
            this.btn_movimentos.Text = "Movimentos";
            this.btn_movimentos.UseVisualStyleBackColor = true;
            this.btn_movimentos.Click += new System.EventHandler(this.Btn_movimentos_Click);
            // 
            // btn_habilidades
            // 
            this.btn_habilidades.Location = new System.Drawing.Point(324, 211);
            this.btn_habilidades.Name = "btn_habilidades";
            this.btn_habilidades.Size = new System.Drawing.Size(100, 50);
            this.btn_habilidades.TabIndex = 13;
            this.btn_habilidades.Text = "Habilidades";
            this.btn_habilidades.UseVisualStyleBackColor = true;
            this.btn_habilidades.Click += new System.EventHandler(this.Btn_habilidades_Click);
            // 
            // btn_localizacao
            // 
            this.btn_localizacao.Location = new System.Drawing.Point(218, 211);
            this.btn_localizacao.Name = "btn_localizacao";
            this.btn_localizacao.Size = new System.Drawing.Size(100, 50);
            this.btn_localizacao.TabIndex = 12;
            this.btn_localizacao.Text = "Localização";
            this.btn_localizacao.UseVisualStyleBackColor = true;
            this.btn_localizacao.Click += new System.EventHandler(this.Btn_localizacao_Click);
            // 
            // btn_altura
            // 
            this.btn_altura.Location = new System.Drawing.Point(324, 267);
            this.btn_altura.Name = "btn_altura";
            this.btn_altura.Size = new System.Drawing.Size(100, 50);
            this.btn_altura.TabIndex = 19;
            this.btn_altura.Text = "Altura";
            this.btn_altura.UseVisualStyleBackColor = true;
            this.btn_altura.Click += new System.EventHandler(this.Btn_altura_Click);
            // 
            // btn_peso
            // 
            this.btn_peso.Location = new System.Drawing.Point(218, 267);
            this.btn_peso.Name = "btn_peso";
            this.btn_peso.Size = new System.Drawing.Size(100, 50);
            this.btn_peso.TabIndex = 18;
            this.btn_peso.Text = "Peso";
            this.btn_peso.UseVisualStyleBackColor = true;
            this.btn_peso.Click += new System.EventHandler(this.Btn_peso_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(590, 12);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 20;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // DetalhesPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 329);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_altura);
            this.Controls.Add(this.btn_peso);
            this.Controls.Add(this.btn_experienciaBase);
            this.Controls.Add(this.btn_movimentos);
            this.Controls.Add(this.btn_habilidades);
            this.Controls.Add(this.btn_localizacao);
            this.Controls.Add(this.txtbox_detalhes);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.btn_tipo);
            this.Controls.Add(this.img_pokemon);
            this.Controls.Add(this.lbl_nomePokemon);
            this.MaximizeBox = false;
            this.Name = "DetalhesPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.img_pokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_pokemon;
        private System.Windows.Forms.Label lbl_nomePokemon;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Button btn_tipo;
        private System.Windows.Forms.TextBox txtbox_detalhes;
        private System.Windows.Forms.Button btn_experienciaBase;
        private System.Windows.Forms.Button btn_movimentos;
        private System.Windows.Forms.Button btn_habilidades;
        private System.Windows.Forms.Button btn_localizacao;
        private System.Windows.Forms.Button btn_altura;
        private System.Windows.Forms.Button btn_peso;
        private System.Windows.Forms.Button btn_limpar;
    }
}