namespace TrackerUI
{
    partial class NewEnvForm
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
            envCodeLabel = new Label();
            envCodeValue = new TextBox();
            envNameValue = new TextBox();
            envNameLabel = new Label();
            envDetailsLabel = new Label();
            textBox1 = new TextBox();
            createEnvButton = new Button();
            SuspendLayout();
            // 
            // envCodeLabel
            // 
            envCodeLabel.AutoSize = true;
            envCodeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            envCodeLabel.Location = new Point(19, 33);
            envCodeLabel.Margin = new Padding(5, 0, 5, 0);
            envCodeLabel.Name = "envCodeLabel";
            envCodeLabel.Size = new Size(168, 25);
            envCodeLabel.TabIndex = 0;
            envCodeLabel.Text = "Environment Code";
            // 
            // envCodeValue
            // 
            envCodeValue.Location = new Point(195, 30);
            envCodeValue.Name = "envCodeValue";
            envCodeValue.Size = new Size(172, 33);
            envCodeValue.TabIndex = 1;
            // 
            // envNameValue
            // 
            envNameValue.Location = new Point(195, 100);
            envNameValue.Name = "envNameValue";
            envNameValue.Size = new Size(172, 33);
            envNameValue.TabIndex = 3;
            // 
            // envNameLabel
            // 
            envNameLabel.AutoSize = true;
            envNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            envNameLabel.Location = new Point(19, 103);
            envNameLabel.Margin = new Padding(5, 0, 5, 0);
            envNameLabel.Name = "envNameLabel";
            envNameLabel.Size = new Size(174, 25);
            envNameLabel.TabIndex = 2;
            envNameLabel.Text = "Environment Name";
            // 
            // envDetailsLabel
            // 
            envDetailsLabel.AutoSize = true;
            envDetailsLabel.Location = new Point(19, 165);
            envDetailsLabel.Name = "envDetailsLabel";
            envDetailsLabel.Size = new Size(181, 25);
            envDetailsLabel.TabIndex = 4;
            envDetailsLabel.Text = "Environment Details";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 193);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 127);
            textBox1.TabIndex = 5;
            // 
            // createEnvButton
            // 
            createEnvButton.Location = new Point(78, 348);
            createEnvButton.Name = "createEnvButton";
            createEnvButton.Size = new Size(230, 61);
            createEnvButton.TabIndex = 6;
            createEnvButton.Text = "Create Environment";
            createEnvButton.UseVisualStyleBackColor = true;
            // 
            // NewEnvForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 445);
            Controls.Add(createEnvButton);
            Controls.Add(textBox1);
            Controls.Add(envDetailsLabel);
            Controls.Add(envNameValue);
            Controls.Add(envNameLabel);
            Controls.Add(envCodeValue);
            Controls.Add(envCodeLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "NewEnvForm";
            Text = "Create Environment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label envCodeLabel;
        private TextBox envCodeValue;
        private TextBox envNameValue;
        private Label envNameLabel;
        private Label envDetailsLabel;
        private TextBox textBox1;
        private Button createEnvButton;
    }
}
