namespace PresidentialEligibilityWinForm
{
    partial class EligibilityTest
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
            this.IsNaturalBorn = new System.Windows.Forms.CheckBox();
            this.Submit = new System.Windows.Forms.Button();
            this.AgeSlider = new System.Windows.Forms.NumericUpDown();
            this.labelAge = new System.Windows.Forms.Label();
            this.ResidedSlider = new System.Windows.Forms.NumericUpDown();
            this.labelResidential = new System.Windows.Forms.Label();
            this.labelServed = new System.Windows.Forms.Label();
            this.PresidentSlider = new System.Windows.Forms.NumericUpDown();
            this.Elegibility = new System.Windows.Forms.Label();
            this.HaveRebelled = new System.Windows.Forms.CheckBox();
            this.IsImpeached = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresidentSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // IsNaturalBorn
            // 
            this.IsNaturalBorn.AccessibleName = "";
            this.IsNaturalBorn.AutoSize = true;
            this.IsNaturalBorn.Location = new System.Drawing.Point(72, 31);
            this.IsNaturalBorn.Name = "IsNaturalBorn";
            this.IsNaturalBorn.Size = new System.Drawing.Size(145, 20);
            this.IsNaturalBorn.TabIndex = 0;
            this.IsNaturalBorn.Text = "Natural Born Citizen";
            this.IsNaturalBorn.UseVisualStyleBackColor = true;
            this.IsNaturalBorn.CheckedChanged += new System.EventHandler(this.IsNaturalBorn_CheckedChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(293, 383);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(156, 35);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Determine Elegibility";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AgeSlider
            // 
            this.AgeSlider.Location = new System.Drawing.Point(72, 73);
            this.AgeSlider.Name = "AgeSlider";
            this.AgeSlider.Size = new System.Drawing.Size(120, 22);
            this.AgeSlider.TabIndex = 2;
            this.AgeSlider.ValueChanged += new System.EventHandler(this.AgeSlider_ValueChanged);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(80, 54);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(114, 16);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "What is your age?";
            // 
            // ResidedSlider
            // 
            this.ResidedSlider.Location = new System.Drawing.Point(72, 117);
            this.ResidedSlider.Name = "ResidedSlider";
            this.ResidedSlider.Size = new System.Drawing.Size(120, 22);
            this.ResidedSlider.TabIndex = 4;
            this.ResidedSlider.ValueChanged += new System.EventHandler(this.ResidedSlider_ValueChanged);
            // 
            // labelResidential
            // 
            this.labelResidential.AutoSize = true;
            this.labelResidential.Location = new System.Drawing.Point(80, 98);
            this.labelResidential.Name = "labelResidential";
            this.labelResidential.Size = new System.Drawing.Size(286, 16);
            this.labelResidential.TabIndex = 5;
            this.labelResidential.Text = "How many years have you resided in the USA?";
            // 
            // labelServed
            // 
            this.labelServed.AutoSize = true;
            this.labelServed.Location = new System.Drawing.Point(80, 151);
            this.labelServed.Name = "labelServed";
            this.labelServed.Size = new System.Drawing.Size(361, 16);
            this.labelServed.TabIndex = 6;
            this.labelServed.Text = "How many years have you served as President of the USA?";
            // 
            // PresidentSlider
            // 
            this.PresidentSlider.Location = new System.Drawing.Point(72, 170);
            this.PresidentSlider.Name = "PresidentSlider";
            this.PresidentSlider.Size = new System.Drawing.Size(120, 22);
            this.PresidentSlider.TabIndex = 7;
            this.PresidentSlider.ValueChanged += new System.EventHandler(this.PresidentSlider_ValueChanged);
            // 
            // Elegibility
            // 
            this.Elegibility.AutoSize = true;
            this.Elegibility.Location = new System.Drawing.Point(592, 150);
            this.Elegibility.Name = "Elegibility";
            this.Elegibility.Size = new System.Drawing.Size(122, 16);
            this.Elegibility.TabIndex = 8;
            this.Elegibility.Text = "Eligibility Pending...";
            // 
            // HaveRebelled
            // 
            this.HaveRebelled.AutoSize = true;
            this.HaveRebelled.Location = new System.Drawing.Point(72, 209);
            this.HaveRebelled.Name = "HaveRebelled";
            this.HaveRebelled.Size = new System.Drawing.Size(217, 20);
            this.HaveRebelled.TabIndex = 9;
            this.HaveRebelled.Text = "I have rebelled against the USA";
            this.HaveRebelled.UseVisualStyleBackColor = true;
            this.HaveRebelled.CheckedChanged += new System.EventHandler(this.HaveRebelled_CheckedChanged);
            // 
            // IsImpeached
            // 
            this.IsImpeached.AutoSize = true;
            this.IsImpeached.Location = new System.Drawing.Point(72, 236);
            this.IsImpeached.Name = "IsImpeached";
            this.IsImpeached.Size = new System.Drawing.Size(170, 20);
            this.IsImpeached.TabIndex = 10;
            this.IsImpeached.Text = "I have been impeached";
            this.IsImpeached.UseVisualStyleBackColor = true;
            this.IsImpeached.CheckedChanged += new System.EventHandler(this.IsImpeached_CheckedChanged);
            // 
            // EligibilityTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IsImpeached);
            this.Controls.Add(this.HaveRebelled);
            this.Controls.Add(this.Elegibility);
            this.Controls.Add(this.PresidentSlider);
            this.Controls.Add(this.labelServed);
            this.Controls.Add(this.labelResidential);
            this.Controls.Add(this.ResidedSlider);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.AgeSlider);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.IsNaturalBorn);
            this.Name = "EligibilityTest";
            this.Text = "US Presidential Eligibility Test";
            ((System.ComponentModel.ISupportInitialize)(this.AgeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresidentSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsNaturalBorn;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.NumericUpDown AgeSlider;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.NumericUpDown ResidedSlider;
        private System.Windows.Forms.Label labelResidential;
        private System.Windows.Forms.Label labelServed;
        private System.Windows.Forms.NumericUpDown PresidentSlider;
        private System.Windows.Forms.Label Elegibility;
        private System.Windows.Forms.CheckBox HaveRebelled;
        private System.Windows.Forms.CheckBox IsImpeached;
    }
}

