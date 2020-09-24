namespace ClassInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.positionInput = new System.Windows.Forms.TextBox();
            this.teamInput = new System.Windows.Forms.TextBox();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.removeBox = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeInput = new System.Windows.Forms.TextBox();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.TextBox();
            this.addBox.SuspendLayout();
            this.removeBox.SuspendLayout();
            this.displayBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBox
            // 
            this.addBox.Controls.Add(this.addButton);
            this.addBox.Controls.Add(this.positionInput);
            this.addBox.Controls.Add(this.teamInput);
            this.addBox.Controls.Add(this.ageInput);
            this.addBox.Controls.Add(this.nameInput);
            this.addBox.Controls.Add(this.positionLabel);
            this.addBox.Controls.Add(this.teamLabel);
            this.addBox.Controls.Add(this.ageLabel);
            this.addBox.Controls.Add(this.nameLabel);
            this.addBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBox.ForeColor = System.Drawing.Color.White;
            this.addBox.Location = new System.Drawing.Point(32, 69);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(208, 219);
            this.addBox.TabIndex = 0;
            this.addBox.TabStop = false;
            this.addBox.Text = "New Player";
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(119, 169);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 37);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // positionInput
            // 
            this.positionInput.Location = new System.Drawing.Point(73, 133);
            this.positionInput.Name = "positionInput";
            this.positionInput.Size = new System.Drawing.Size(121, 22);
            this.positionInput.TabIndex = 7;
            // 
            // teamInput
            // 
            this.teamInput.Location = new System.Drawing.Point(73, 98);
            this.teamInput.Name = "teamInput";
            this.teamInput.Size = new System.Drawing.Size(121, 22);
            this.teamInput.TabIndex = 6;
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(73, 65);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(36, 22);
            this.ageInput.TabIndex = 5;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(73, 33);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(121, 22);
            this.nameInput.TabIndex = 4;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(6, 137);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(54, 17);
            this.positionLabel.TabIndex = 3;
            this.positionLabel.Text = "Position";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel.Location = new System.Drawing.Point(7, 103);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(39, 17);
            this.teamLabel.TabIndex = 2;
            this.teamLabel.Text = "Team";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(7, 65);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(31, 17);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Age";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(7, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-3, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(598, 56);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Team Database";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeBox
            // 
            this.removeBox.Controls.Add(this.removeButton);
            this.removeBox.Controls.Add(this.removeInput);
            this.removeBox.Controls.Add(this.nameLabel2);
            this.removeBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBox.ForeColor = System.Drawing.Color.White;
            this.removeBox.Location = new System.Drawing.Point(32, 308);
            this.removeBox.Name = "removeBox";
            this.removeBox.Size = new System.Drawing.Size(208, 120);
            this.removeBox.TabIndex = 2;
            this.removeBox.TabStop = false;
            this.removeBox.Text = "Remove Player";
            // 
            // removeButton
            // 
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(119, 65);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 37);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeInput
            // 
            this.removeInput.Location = new System.Drawing.Point(73, 33);
            this.removeInput.Name = "removeInput";
            this.removeInput.Size = new System.Drawing.Size(121, 22);
            this.removeInput.TabIndex = 4;
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(7, 33);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(43, 17);
            this.nameLabel2.TabIndex = 0;
            this.nameLabel2.Text = "Name";
            // 
            // displayBox
            // 
            this.displayBox.Controls.Add(this.outputLabel);
            this.displayBox.Controls.Add(this.showButton);
            this.displayBox.Controls.Add(this.searchButton);
            this.displayBox.Controls.Add(this.searchInput);
            this.displayBox.Controls.Add(this.nameLabel3);
            this.displayBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.ForeColor = System.Drawing.Color.White;
            this.displayBox.Location = new System.Drawing.Point(269, 69);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(289, 359);
            this.displayBox.TabIndex = 3;
            this.displayBox.TabStop = false;
            this.displayBox.Text = "Output";
            // 
            // showButton
            // 
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Location = new System.Drawing.Point(202, 65);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 22);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(202, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 22);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(73, 33);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(121, 22);
            this.searchInput.TabIndex = 4;
            // 
            // nameLabel3
            // 
            this.nameLabel3.AutoSize = true;
            this.nameLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel3.Location = new System.Drawing.Point(9, 33);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(43, 17);
            this.nameLabel3.TabIndex = 0;
            this.nameLabel3.Text = "Name";
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(12, 103);
            this.outputLabel.Multiline = true;
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.ReadOnly = true;
            this.outputLabel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputLabel.Size = new System.Drawing.Size(265, 243);
            this.outputLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(591, 454);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.removeBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Class Inventory";
            this.addBox.ResumeLayout(false);
            this.addBox.PerformLayout();
            this.removeBox.ResumeLayout(false);
            this.removeBox.PerformLayout();
            this.displayBox.ResumeLayout(false);
            this.displayBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox positionInput;
        private System.Windows.Forms.TextBox teamInput;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox removeBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox removeInput;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.GroupBox displayBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.TextBox outputLabel;
    }
}

