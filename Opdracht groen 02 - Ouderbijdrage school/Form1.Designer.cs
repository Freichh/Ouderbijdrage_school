namespace Opdracht_groen_02___Ouderbijdrage_school
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
            this.eenOuderGezinCheckbox = new System.Windows.Forms.CheckBox();
            this.aantalKinderenNumeric = new System.Windows.Forms.NumericUpDown();
            this.eenOuderGezinLabel = new System.Windows.Forms.Label();
            this.aantalKinderenLabel = new System.Windows.Forms.Label();
            this.geboortedatumFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.berekenButton = new System.Windows.Forms.Button();
            this.totaalbedragTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aantalKinderenNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // eenOuderGezinCheckbox
            // 
            this.eenOuderGezinCheckbox.AutoSize = true;
            this.eenOuderGezinCheckbox.Location = new System.Drawing.Point(208, 27);
            this.eenOuderGezinCheckbox.Name = "eenOuderGezinCheckbox";
            this.eenOuderGezinCheckbox.Size = new System.Drawing.Size(18, 17);
            this.eenOuderGezinCheckbox.TabIndex = 0;
            this.eenOuderGezinCheckbox.UseVisualStyleBackColor = true;
            this.eenOuderGezinCheckbox.CheckedChanged += new System.EventHandler(this.eenOuderGezinCheckbox_CheckedChanged);
            // 
            // aantalKinderenNumeric
            // 
            this.aantalKinderenNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantalKinderenNumeric.Location = new System.Drawing.Point(208, 57);
            this.aantalKinderenNumeric.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.aantalKinderenNumeric.Name = "aantalKinderenNumeric";
            this.aantalKinderenNumeric.Size = new System.Drawing.Size(75, 26);
            this.aantalKinderenNumeric.TabIndex = 2;
            this.aantalKinderenNumeric.ValueChanged += new System.EventHandler(this.aantalKinderenNumeric_ValueChanged);
            // 
            // eenOuderGezinLabel
            // 
            this.eenOuderGezinLabel.AutoSize = true;
            this.eenOuderGezinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eenOuderGezinLabel.Location = new System.Drawing.Point(23, 23);
            this.eenOuderGezinLabel.Name = "eenOuderGezinLabel";
            this.eenOuderGezinLabel.Size = new System.Drawing.Size(143, 20);
            this.eenOuderGezinLabel.TabIndex = 3;
            this.eenOuderGezinLabel.Text = "Eénoudergezin j/n";
            // 
            // aantalKinderenLabel
            // 
            this.aantalKinderenLabel.AutoSize = true;
            this.aantalKinderenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantalKinderenLabel.Location = new System.Drawing.Point(42, 59);
            this.aantalKinderenLabel.Name = "aantalKinderenLabel";
            this.aantalKinderenLabel.Size = new System.Drawing.Size(124, 20);
            this.aantalKinderenLabel.TabIndex = 4;
            this.aantalKinderenLabel.Text = "Aantal kinderen";
            // 
            // geboortedatumFlowLayoutPanel
            // 
            this.geboortedatumFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.geboortedatumFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.geboortedatumFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.geboortedatumFlowLayoutPanel.Location = new System.Drawing.Point(12, 103);
            this.geboortedatumFlowLayoutPanel.Name = "geboortedatumFlowLayoutPanel";
            this.geboortedatumFlowLayoutPanel.Size = new System.Drawing.Size(1226, 252);
            this.geboortedatumFlowLayoutPanel.TabIndex = 7;
            // 
            // berekenButton
            // 
            this.berekenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berekenButton.Location = new System.Drawing.Point(12, 377);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(175, 34);
            this.berekenButton.TabIndex = 8;
            this.berekenButton.Text = "Bereken totaal";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // totaalbedragTextBox
            // 
            this.totaalbedragTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaalbedragTextBox.Location = new System.Drawing.Point(208, 380);
            this.totaalbedragTextBox.Name = "totaalbedragTextBox";
            this.totaalbedragTextBox.Size = new System.Drawing.Size(100, 26);
            this.totaalbedragTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 434);
            this.Controls.Add(this.totaalbedragTextBox);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.geboortedatumFlowLayoutPanel);
            this.Controls.Add(this.aantalKinderenLabel);
            this.Controls.Add(this.eenOuderGezinLabel);
            this.Controls.Add(this.aantalKinderenNumeric);
            this.Controls.Add(this.eenOuderGezinCheckbox);
            this.Name = "Form1";
            this.Text = "Ouderbijdrage berekenen - by: Freek Heining";
            ((System.ComponentModel.ISupportInitialize)(this.aantalKinderenNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox eenOuderGezinCheckbox;
        private System.Windows.Forms.NumericUpDown aantalKinderenNumeric;
        private System.Windows.Forms.Label eenOuderGezinLabel;
        private System.Windows.Forms.Label aantalKinderenLabel;
        private System.Windows.Forms.TextBox totaalBedrag;
        private System.Windows.Forms.FlowLayoutPanel geboortedatumFlowLayoutPanel;
        private System.Windows.Forms.Button berekenButton;
        private System.Windows.Forms.TextBox totaalbedragTextBox;
    }
}

