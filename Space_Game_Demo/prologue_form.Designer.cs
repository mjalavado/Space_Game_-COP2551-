
namespace Space_Game_Demo
{
    partial class prologue_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prologue_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContinuePrologue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(126, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 196);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(245, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Story Summary:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinuePrologue
            // 
            this.btnContinuePrologue.BackColor = System.Drawing.Color.Black;
            this.btnContinuePrologue.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuePrologue.ForeColor = System.Drawing.Color.White;
            this.btnContinuePrologue.Location = new System.Drawing.Point(350, 381);
            this.btnContinuePrologue.Name = "btnContinuePrologue";
            this.btnContinuePrologue.Size = new System.Drawing.Size(287, 64);
            this.btnContinuePrologue.TabIndex = 4;
            this.btnContinuePrologue.Text = "Continue";
            this.btnContinuePrologue.UseVisualStyleBackColor = false;
            // 
            // prologue_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 561);
            this.Controls.Add(this.btnContinuePrologue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "prologue_form";
            this.Text = "prologue_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContinuePrologue;
    }
}