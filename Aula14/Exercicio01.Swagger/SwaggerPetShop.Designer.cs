﻿namespace Exercicio01.Swagger
{
    partial class SwaggerPetShop
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
            this.buttonInserirAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInserirAnimal
            // 
            this.buttonInserirAnimal.Location = new System.Drawing.Point(155, 105);
            this.buttonInserirAnimal.Name = "buttonInserirAnimal";
            this.buttonInserirAnimal.Size = new System.Drawing.Size(186, 75);
            this.buttonInserirAnimal.TabIndex = 0;
            this.buttonInserirAnimal.Text = "INSERIR ANIMAL";
            this.buttonInserirAnimal.UseVisualStyleBackColor = true;
            this.buttonInserirAnimal.Click += new System.EventHandler(this.buttonInserirAnimal_Click);
            // 
            // SwaggerPetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 282);
            this.Controls.Add(this.buttonInserirAnimal);
            this.Name = "SwaggerPetShop";
            this.Text = "SwaggerPetShop";
            this.Load += new System.EventHandler(this.SwaggerPetShop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInserirAnimal;
    }
}