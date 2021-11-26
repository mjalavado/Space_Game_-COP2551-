
namespace Space_Game_Demo
{
    partial class high_risk_planet_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(high_risk_planet_form));
            this.pctHighRiskPlanet = new System.Windows.Forms.PictureBox();
            this.btnSalvage = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctHighRiskPlanet)).BeginInit();
            this.SuspendLayout();
            // 
            // pctHighRiskPlanet
            // 
            this.pctHighRiskPlanet.BackColor = System.Drawing.Color.Transparent;
            this.pctHighRiskPlanet.Image = ((System.Drawing.Image)(resources.GetObject("pctHighRiskPlanet.Image")));
            this.pctHighRiskPlanet.Location = new System.Drawing.Point(465, 59);
            this.pctHighRiskPlanet.Name = "pctHighRiskPlanet";
            this.pctHighRiskPlanet.Size = new System.Drawing.Size(257, 266);
            this.pctHighRiskPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHighRiskPlanet.TabIndex = 22;
            this.pctHighRiskPlanet.TabStop = false;
            // 
            // btnSalvage
            // 
            this.btnSalvage.BackColor = System.Drawing.Color.Black;
            this.btnSalvage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvage.ForeColor = System.Drawing.Color.White;
            this.btnSalvage.Location = new System.Drawing.Point(453, 368);
            this.btnSalvage.Name = "btnSalvage";
            this.btnSalvage.Size = new System.Drawing.Size(287, 64);
            this.btnSalvage.TabIndex = 23;
            this.btnSalvage.Text = "Salvage";
            this.btnSalvage.UseVisualStyleBackColor = false;
            this.btnSalvage.Click += new System.EventHandler(this.btnSalvage_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Black;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(453, 474);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(287, 64);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Leave Planet";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // high_risk_planet_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1223, 598);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSalvage);
            this.Controls.Add(this.pctHighRiskPlanet);
            this.Name = "high_risk_planet_form";
            this.Text = "high_risk_planet_form";
            ((System.ComponentModel.ISupportInitialize)(this.pctHighRiskPlanet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctHighRiskPlanet;
        private System.Windows.Forms.Button btnSalvage;
        private System.Windows.Forms.Button btnReturn;
    }
}