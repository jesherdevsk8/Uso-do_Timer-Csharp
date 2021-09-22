namespace UsoTimer_Jesher
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer01 = new System.Windows.Forms.Timer(this.components);
            this.btnon = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.lblExibe = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer01
            // 
            this.timer01.Interval = 1000;
            this.timer01.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnon
            // 
            this.btnon.Location = new System.Drawing.Point(71, 94);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(94, 31);
            this.btnon.TabIndex = 0;
            this.btnon.Text = "Turn On Timer";
            this.btnon.UseVisualStyleBackColor = true;
            this.btnon.Click += new System.EventHandler(this.Btnon_Click);
            // 
            // btnoff
            // 
            this.btnoff.Location = new System.Drawing.Point(71, 144);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(94, 31);
            this.btnoff.TabIndex = 1;
            this.btnoff.Text = "Turn Off Timer";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.Btnoff_Click);
            // 
            // lblExibe
            // 
            this.lblExibe.AutoSize = true;
            this.lblExibe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibe.Location = new System.Drawing.Point(56, 23);
            this.lblExibe.Name = "lblExibe";
            this.lblExibe.Size = new System.Drawing.Size(88, 15);
            this.lblExibe.TabIndex = 2;
            this.lblExibe.Text = "DateTimeNow";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(56, 50);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(104, 15);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "Tempo Decorrido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desenvolvido por: Jesher Minelli Alves";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblExibe);
            this.Controls.Add(this.btnoff);
            this.Controls.Add(this.btnon);
            this.Name = "Form1";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer01;
        private System.Windows.Forms.Button btnon;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Label lblExibe;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

