
namespace Practical6
{
    partial class frmAbahambeLift
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
            this.gbxPickup = new System.Windows.Forms.GroupBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lbxDestination = new System.Windows.Forms.ListBox();
            this.cbxReturnTrip = new System.Windows.Forms.CheckBox();
            this.rbtnIkageng = new System.Windows.Forms.RadioButton();
            this.rbtnPromosa = new System.Windows.Forms.RadioButton();
            this.rbtnMohadin = new System.Windows.Forms.RadioButton();
            this.lblNumberOfTicket = new System.Windows.Forms.Label();
            this.btnBookLift = new System.Windows.Forms.Button();
            this.txtBookLift = new System.Windows.Forms.TextBox();
            this.gbxPickup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPickup
            // 
            this.gbxPickup.Controls.Add(this.rbtnMohadin);
            this.gbxPickup.Controls.Add(this.rbtnPromosa);
            this.gbxPickup.Controls.Add(this.rbtnIkageng);
            this.gbxPickup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPickup.Location = new System.Drawing.Point(12, 29);
            this.gbxPickup.Name = "gbxPickup";
            this.gbxPickup.Size = new System.Drawing.Size(460, 202);
            this.gbxPickup.TabIndex = 0;
            this.gbxPickup.TabStop = false;
            this.gbxPickup.Text = "Potchefstroom Pickup Point";
            // 
            // lblDestination
            // 
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(9, 259);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(100, 23);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination:";
            // 
            // lbxDestination
            // 
            this.lbxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDestination.FormattingEnabled = true;
            this.lbxDestination.ItemHeight = 20;
            this.lbxDestination.Items.AddRange(new object[] {
            "Johannesburg",
            "Pretoria",
            "Randfontein"});
            this.lbxDestination.Location = new System.Drawing.Point(12, 285);
            this.lbxDestination.Name = "lbxDestination";
            this.lbxDestination.Size = new System.Drawing.Size(460, 144);
            this.lbxDestination.TabIndex = 2;
            // 
            // cbxReturnTrip
            // 
            this.cbxReturnTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReturnTrip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxReturnTrip.Location = new System.Drawing.Point(13, 435);
            this.cbxReturnTrip.Name = "cbxReturnTrip";
            this.cbxReturnTrip.Size = new System.Drawing.Size(104, 24);
            this.cbxReturnTrip.TabIndex = 3;
            this.cbxReturnTrip.Text = "Return trip?";
            this.cbxReturnTrip.UseVisualStyleBackColor = true;
            this.cbxReturnTrip.CheckedChanged += new System.EventHandler(this.cbxReturnTrip_CheckedChanged);
            // 
            // rbtnIkageng
            // 
            this.rbtnIkageng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIkageng.Location = new System.Drawing.Point(15, 39);
            this.rbtnIkageng.Name = "rbtnIkageng";
            this.rbtnIkageng.Size = new System.Drawing.Size(249, 24);
            this.rbtnIkageng.TabIndex = 0;
            this.rbtnIkageng.TabStop = true;
            this.rbtnIkageng.Text = "Potchefstroom Ikageng";
            this.rbtnIkageng.UseVisualStyleBackColor = true;
            // 
            // rbtnPromosa
            // 
            this.rbtnPromosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPromosa.Location = new System.Drawing.Point(15, 96);
            this.rbtnPromosa.Name = "rbtnPromosa";
            this.rbtnPromosa.Size = new System.Drawing.Size(249, 24);
            this.rbtnPromosa.TabIndex = 1;
            this.rbtnPromosa.TabStop = true;
            this.rbtnPromosa.Text = "Potchefstroom Promosa";
            this.rbtnPromosa.UseVisualStyleBackColor = true;
            // 
            // rbtnMohadin
            // 
            this.rbtnMohadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMohadin.Location = new System.Drawing.Point(15, 152);
            this.rbtnMohadin.Name = "rbtnMohadin";
            this.rbtnMohadin.Size = new System.Drawing.Size(249, 24);
            this.rbtnMohadin.TabIndex = 2;
            this.rbtnMohadin.TabStop = true;
            this.rbtnMohadin.Text = "Potchefstroom Mohadin";
            this.rbtnMohadin.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfTicket
            // 
            this.lblNumberOfTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTicket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumberOfTicket.Location = new System.Drawing.Point(12, 475);
            this.lblNumberOfTicket.Name = "lblNumberOfTicket";
            this.lblNumberOfTicket.Size = new System.Drawing.Size(100, 23);
            this.lblNumberOfTicket.TabIndex = 4;
            this.lblNumberOfTicket.Text = "No. of Tickets:";
            // 
            // btnBookLift
            // 
            this.btnBookLift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBookLift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookLift.Location = new System.Drawing.Point(12, 504);
            this.btnBookLift.Name = "btnBookLift";
            this.btnBookLift.Size = new System.Drawing.Size(460, 51);
            this.btnBookLift.TabIndex = 5;
            this.btnBookLift.Text = "Book Lift";
            this.btnBookLift.UseVisualStyleBackColor = false;
            this.btnBookLift.Click += new System.EventHandler(this.btnBookLift_Click);
            // 
            // txtBookLift
            // 
            this.txtBookLift.Location = new System.Drawing.Point(152, 474);
            this.txtBookLift.Name = "txtBookLift";
            this.txtBookLift.Size = new System.Drawing.Size(59, 20);
            this.txtBookLift.TabIndex = 6;
            // 
            // frmAbahambeLift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(488, 566);
            this.Controls.Add(this.txtBookLift);
            this.Controls.Add(this.btnBookLift);
            this.Controls.Add(this.lblNumberOfTicket);
            this.Controls.Add(this.cbxReturnTrip);
            this.Controls.Add(this.lbxDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.gbxPickup);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmAbahambeLift";
            this.Text = "Abahambe Lifts";
            this.gbxPickup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPickup;
        private System.Windows.Forms.RadioButton rbtnMohadin;
        private System.Windows.Forms.RadioButton rbtnPromosa;
        private System.Windows.Forms.RadioButton rbtnIkageng;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.ListBox lbxDestination;
        private System.Windows.Forms.CheckBox cbxReturnTrip;
        private System.Windows.Forms.Label lblNumberOfTicket;
        private System.Windows.Forms.Button btnBookLift;
        private System.Windows.Forms.TextBox txtBookLift;
    }
}

