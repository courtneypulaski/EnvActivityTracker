namespace TrackerUI
{
    partial class CreateEnvForm
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
            envCodeLabel = new Label();
            envNameLabel = new Label();
            envDetailsLabel = new Label();
            envCodeValue = new TextBox();
            envNameValue = new TextBox();
            envDetailsValue = new TextBox();
            createEnvButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // envCodeLabel
            // 
            envCodeLabel.AutoSize = true;
            envCodeLabel.Location = new Point(36, 74);
            envCodeLabel.Name = "envCodeLabel";
            envCodeLabel.Size = new Size(168, 25);
            envCodeLabel.TabIndex = 0;
            envCodeLabel.Text = "Environment Code";
            // 
            // envNameLabel
            // 
            envNameLabel.AutoSize = true;
            envNameLabel.Location = new Point(36, 129);
            envNameLabel.Name = "envNameLabel";
            envNameLabel.Size = new Size(174, 25);
            envNameLabel.TabIndex = 1;
            envNameLabel.Text = "Environment Name";
            // 
            // envDetailsLabel
            // 
            envDetailsLabel.AutoSize = true;
            envDetailsLabel.Location = new Point(36, 184);
            envDetailsLabel.Name = "envDetailsLabel";
            envDetailsLabel.Size = new Size(181, 25);
            envDetailsLabel.TabIndex = 2;
            envDetailsLabel.Text = "Environment Details";
            // 
            // envCodeValue
            // 
            envCodeValue.Location = new Point(234, 71);
            envCodeValue.Name = "envCodeValue";
            envCodeValue.Size = new Size(223, 33);
            envCodeValue.TabIndex = 3;
            // 
            // envNameValue
            // 
            envNameValue.Location = new Point(234, 126);
            envNameValue.Name = "envNameValue";
            envNameValue.Size = new Size(223, 33);
            envNameValue.TabIndex = 4;
            // 
            // envDetailsValue
            // 
            envDetailsValue.Location = new Point(36, 231);
            envDetailsValue.Multiline = true;
            envDetailsValue.Name = "envDetailsValue";
            envDetailsValue.Size = new Size(421, 149);
            envDetailsValue.TabIndex = 5;
            // 
            // createEnvButton
            // 
            createEnvButton.Location = new Point(147, 416);
            createEnvButton.Name = "createEnvButton";
            createEnvButton.Size = new Size(221, 50);
            createEnvButton.TabIndex = 6;
            createEnvButton.Text = "Create Environment";
            createEnvButton.UseVisualStyleBackColor = true;
            createEnvButton.Click += createEnvButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 7;
            label1.Text = "New Environment";
            // 
            // CreateEnvForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(494, 508);
            Controls.Add(label1);
            Controls.Add(createEnvButton);
            Controls.Add(envDetailsValue);
            Controls.Add(envNameValue);
            Controls.Add(envCodeValue);
            Controls.Add(envDetailsLabel);
            Controls.Add(envNameLabel);
            Controls.Add(envCodeLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "CreateEnvForm";
            Text = "Create Environment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label envCodeLabel;
        private Label envNameLabel;
        private Label envDetailsLabel;
        private TextBox envCodeValue;
        private TextBox envNameValue;
        private TextBox envDetailsValue;
        private Button createEnvButton;
        private Label label1;
    }
}