
namespace Pokedex
{
    partial class Pokedex
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
            this.lbl_nomePokemon = new System.Windows.Forms.Label();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_detalhes = new System.Windows.Forms.Button();
            this.img_pokemon = new System.Windows.Forms.PictureBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_pokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nomePokemon
            // 
            this.lbl_nomePokemon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nomePokemon.AutoSize = true;
            this.lbl_nomePokemon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomePokemon.Location = new System.Drawing.Point(12, 32);
            this.lbl_nomePokemon.Name = "lbl_nomePokemon";
            this.lbl_nomePokemon.Size = new System.Drawing.Size(144, 25);
            this.lbl_nomePokemon.TabIndex = 0;
            this.lbl_nomePokemon.Text = "pokemon nome";
            // 
            // btn_proximo
            // 
            this.btn_proximo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_proximo.Location = new System.Drawing.Point(218, 211);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(100, 50);
            this.btn_proximo.TabIndex = 1;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.Btn_proximo_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_anterior.Location = new System.Drawing.Point(218, 267);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(100, 50);
            this.btn_anterior.TabIndex = 2;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.Btn_anterior_Click);
            // 
            // btn_detalhes
            // 
            this.btn_detalhes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_detalhes.Location = new System.Drawing.Point(218, 155);
            this.btn_detalhes.Name = "btn_detalhes";
            this.btn_detalhes.Size = new System.Drawing.Size(100, 50);
            this.btn_detalhes.TabIndex = 3;
            this.btn_detalhes.Text = "Detalhes";
            this.btn_detalhes.UseVisualStyleBackColor = true;
            this.btn_detalhes.Click += new System.EventHandler(this.Btn_detalhes_Click);
            // 
            // img_pokemon
            // 
            this.img_pokemon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.img_pokemon.Location = new System.Drawing.Point(12, 117);
            this.img_pokemon.Name = "img_pokemon";
            this.img_pokemon.Size = new System.Drawing.Size(200, 200);
            this.img_pokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_pokemon.TabIndex = 4;
            this.img_pokemon.TabStop = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_buscar.Location = new System.Drawing.Point(12, 88);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(200, 23);
            this.txt_buscar.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_buscar.Location = new System.Drawing.Point(218, 88);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(99, 61);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Pokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 329);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.img_pokemon);
            this.Controls.Add(this.btn_detalhes);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.lbl_nomePokemon);
            this.MaximizeBox = false;
            this.Name = "Pokedex";
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.img_pokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomePokemon;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_detalhes;
        private System.Windows.Forms.PictureBox img_pokemon;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
    }
}