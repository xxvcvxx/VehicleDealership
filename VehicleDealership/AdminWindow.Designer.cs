namespace VehicleDealership
{

    partial class AdminWindow
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
            this.LoginGroup = new System.Windows.Forms.GroupBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.DataGroup = new System.Windows.Forms.GroupBox();
            this.VehicleGroup = new System.Windows.Forms.GroupBox();
            this.DeleteVehicleButton = new System.Windows.Forms.Button();
            this.EngineInput = new System.Windows.Forms.TextBox();
            this.TypeInput = new System.Windows.Forms.TextBox();
            this.BrandInput = new System.Windows.Forms.TextBox();
            this.Engine = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.VehicleBrand = new System.Windows.Forms.Label();
            this.SendVehicleButton = new System.Windows.Forms.Button();
            this.PaintGroup = new System.Windows.Forms.GroupBox();
            this.DeletePaintButton = new System.Windows.Forms.Button();
            this.ColorSelector = new System.Windows.Forms.Button();
            this.ColorInput = new System.Windows.Forms.TextBox();
            this.MetallicToggle = new System.Windows.Forms.CheckBox();
            this.Color = new System.Windows.Forms.Label();
            this.SendPaintButton = new System.Windows.Forms.Button();
            this.ComponentAddGroup = new System.Windows.Forms.GroupBox();
            this.ComponentDeleteGroup = new System.Windows.Forms.GroupBox();
            this.EngineSelector = new System.Windows.Forms.ComboBox();
            this.BrandSelector = new System.Windows.Forms.ComboBox();
            this.TypeSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Type2 = new System.Windows.Forms.Label();
            this.Engine2 = new System.Windows.Forms.Label();
            this.LoginGroup.SuspendLayout();
            this.DataGroup.SuspendLayout();
            this.VehicleGroup.SuspendLayout();
            this.PaintGroup.SuspendLayout();
            this.ComponentAddGroup.SuspendLayout();
            this.ComponentDeleteGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroup
            // 
            this.LoginGroup.Controls.Add(this.LoginButton);
            this.LoginGroup.Controls.Add(this.label2);
            this.LoginGroup.Controls.Add(this.label1);
            this.LoginGroup.Controls.Add(this.PasswordInput);
            this.LoginGroup.Controls.Add(this.UserNameInput);
            this.LoginGroup.Location = new System.Drawing.Point(12, 12);
            this.LoginGroup.Name = "LoginGroup";
            this.LoginGroup.Size = new System.Drawing.Size(451, 80);
            this.LoginGroup.TabIndex = 0;
            this.LoginGroup.TabStop = false;
            this.LoginGroup.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(348, 32);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(217, 32);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(100, 20);
            this.PasswordInput.TabIndex = 1;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(48, 32);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(100, 20);
            this.UserNameInput.TabIndex = 0;
            // 
            // DataGroup
            // 
            this.DataGroup.Controls.Add(this.VehicleGroup);
            this.DataGroup.Controls.Add(this.PaintGroup);
            this.DataGroup.Location = new System.Drawing.Point(13, 98);
            this.DataGroup.Name = "DataGroup";
            this.DataGroup.Size = new System.Drawing.Size(450, 340);
            this.DataGroup.TabIndex = 1;
            this.DataGroup.TabStop = false;
            this.DataGroup.Text = "Data";
            // 
            // VehicleGroup
            // 
            this.VehicleGroup.Controls.Add(this.ComponentDeleteGroup);
            this.VehicleGroup.Controls.Add(this.ComponentAddGroup);
            this.VehicleGroup.Location = new System.Drawing.Point(7, 19);
            this.VehicleGroup.Name = "VehicleGroup";
            this.VehicleGroup.Size = new System.Drawing.Size(437, 209);
            this.VehicleGroup.TabIndex = 7;
            this.VehicleGroup.TabStop = false;
            this.VehicleGroup.Text = "Vehicle";
            // 
            // DeleteVehicleButton
            // 
            this.DeleteVehicleButton.Location = new System.Drawing.Point(129, 155);
            this.DeleteVehicleButton.Name = "DeleteVehicleButton";
            this.DeleteVehicleButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteVehicleButton.TabIndex = 9;
            this.DeleteVehicleButton.Text = "Delete";
            this.DeleteVehicleButton.UseVisualStyleBackColor = true;
            this.DeleteVehicleButton.Click += new System.EventHandler(this.DeleteVehicleButton_Click);
            // 
            // EngineInput
            // 
            this.EngineInput.Location = new System.Drawing.Point(47, 71);
            this.EngineInput.Name = "EngineInput";
            this.EngineInput.Size = new System.Drawing.Size(100, 20);
            this.EngineInput.TabIndex = 8;
            // 
            // TypeInput
            // 
            this.TypeInput.Location = new System.Drawing.Point(47, 45);
            this.TypeInput.Name = "TypeInput";
            this.TypeInput.Size = new System.Drawing.Size(100, 20);
            this.TypeInput.TabIndex = 7;
            // 
            // BrandInput
            // 
            this.BrandInput.Location = new System.Drawing.Point(47, 19);
            this.BrandInput.Name = "BrandInput";
            this.BrandInput.Size = new System.Drawing.Size(100, 20);
            this.BrandInput.TabIndex = 6;
            this.BrandInput.TextChanged += new System.EventHandler(this.BrandInput_TextChanged);
            // 
            // Engine
            // 
            this.Engine.AutoSize = true;
            this.Engine.Location = new System.Drawing.Point(6, 74);
            this.Engine.Name = "Engine";
            this.Engine.Size = new System.Drawing.Size(40, 13);
            this.Engine.TabIndex = 5;
            this.Engine.Text = "Engine";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(6, 52);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 4;
            this.Type.Text = "Type";
            // 
            // VehicleBrand
            // 
            this.VehicleBrand.AutoSize = true;
            this.VehicleBrand.Location = new System.Drawing.Point(6, 26);
            this.VehicleBrand.Name = "VehicleBrand";
            this.VehicleBrand.Size = new System.Drawing.Size(35, 13);
            this.VehicleBrand.TabIndex = 3;
            this.VehicleBrand.Text = "Brand";
            // 
            // SendVehicleButton
            // 
            this.SendVehicleButton.Location = new System.Drawing.Point(128, 155);
            this.SendVehicleButton.Name = "SendVehicleButton";
            this.SendVehicleButton.Size = new System.Drawing.Size(75, 23);
            this.SendVehicleButton.TabIndex = 0;
            this.SendVehicleButton.Text = "Send";
            this.SendVehicleButton.UseVisualStyleBackColor = true;
            this.SendVehicleButton.Click += new System.EventHandler(this.SendVehicleButton_Click);
            // 
            // PaintGroup
            // 
            this.PaintGroup.Controls.Add(this.DeletePaintButton);
            this.PaintGroup.Controls.Add(this.ColorSelector);
            this.PaintGroup.Controls.Add(this.ColorInput);
            this.PaintGroup.Controls.Add(this.MetallicToggle);
            this.PaintGroup.Controls.Add(this.Color);
            this.PaintGroup.Controls.Add(this.SendPaintButton);
            this.PaintGroup.Location = new System.Drawing.Point(6, 234);
            this.PaintGroup.Name = "PaintGroup";
            this.PaintGroup.Size = new System.Drawing.Size(438, 100);
            this.PaintGroup.TabIndex = 6;
            this.PaintGroup.TabStop = false;
            this.PaintGroup.Text = "Paint";
            // 
            // DeletePaintButton
            // 
            this.DeletePaintButton.Location = new System.Drawing.Point(351, 42);
            this.DeletePaintButton.Name = "DeletePaintButton";
            this.DeletePaintButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePaintButton.TabIndex = 11;
            this.DeletePaintButton.Text = "Delete";
            this.DeletePaintButton.UseVisualStyleBackColor = true;
            this.DeletePaintButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ColorSelector
            // 
            this.ColorSelector.Location = new System.Drawing.Point(162, 31);
            this.ColorSelector.Name = "ColorSelector";
            this.ColorSelector.Size = new System.Drawing.Size(93, 23);
            this.ColorSelector.TabIndex = 10;
            this.ColorSelector.Text = "ColorSelector";
            this.ColorSelector.UseVisualStyleBackColor = true;
            this.ColorSelector.Click += new System.EventHandler(this.ColorSelector_Click);
            // 
            // ColorInput
            // 
            this.ColorInput.Location = new System.Drawing.Point(56, 33);
            this.ColorInput.Name = "ColorInput";
            this.ColorInput.Size = new System.Drawing.Size(100, 20);
            this.ColorInput.TabIndex = 9;
            this.ColorInput.TextChanged += new System.EventHandler(this.ColorInput_TextChanged);
            // 
            // MetallicToggle
            // 
            this.MetallicToggle.AutoSize = true;
            this.MetallicToggle.Location = new System.Drawing.Point(22, 59);
            this.MetallicToggle.Name = "MetallicToggle";
            this.MetallicToggle.Size = new System.Drawing.Size(62, 17);
            this.MetallicToggle.TabIndex = 6;
            this.MetallicToggle.Text = "Metallic";
            this.MetallicToggle.UseVisualStyleBackColor = true;
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(19, 33);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(31, 13);
            this.Color.TabIndex = 5;
            this.Color.Text = "Color";
            // 
            // SendPaintButton
            // 
            this.SendPaintButton.Location = new System.Drawing.Point(351, 71);
            this.SendPaintButton.Name = "SendPaintButton";
            this.SendPaintButton.Size = new System.Drawing.Size(75, 23);
            this.SendPaintButton.TabIndex = 0;
            this.SendPaintButton.Text = "Send";
            this.SendPaintButton.UseVisualStyleBackColor = true;
            this.SendPaintButton.Click += new System.EventHandler(this.SendPaintButton_Click);
            // 
            // ComponentAddGroup
            // 
            this.ComponentAddGroup.Controls.Add(this.BrandInput);
            this.ComponentAddGroup.Controls.Add(this.VehicleBrand);
            this.ComponentAddGroup.Controls.Add(this.SendVehicleButton);
            this.ComponentAddGroup.Controls.Add(this.Engine);
            this.ComponentAddGroup.Controls.Add(this.EngineInput);
            this.ComponentAddGroup.Controls.Add(this.TypeInput);
            this.ComponentAddGroup.Controls.Add(this.Type);
            this.ComponentAddGroup.Location = new System.Drawing.Point(6, 19);
            this.ComponentAddGroup.Name = "ComponentAddGroup";
            this.ComponentAddGroup.Size = new System.Drawing.Size(209, 184);
            this.ComponentAddGroup.TabIndex = 10;
            this.ComponentAddGroup.TabStop = false;
            this.ComponentAddGroup.Text = "Add";
            // 
            // ComponentDeleteGroup
            // 
            this.ComponentDeleteGroup.Controls.Add(this.Engine2);
            this.ComponentDeleteGroup.Controls.Add(this.Type2);
            this.ComponentDeleteGroup.Controls.Add(this.label3);
            this.ComponentDeleteGroup.Controls.Add(this.TypeSelector);
            this.ComponentDeleteGroup.Controls.Add(this.BrandSelector);
            this.ComponentDeleteGroup.Controls.Add(this.EngineSelector);
            this.ComponentDeleteGroup.Controls.Add(this.DeleteVehicleButton);
            this.ComponentDeleteGroup.Location = new System.Drawing.Point(221, 19);
            this.ComponentDeleteGroup.Name = "ComponentDeleteGroup";
            this.ComponentDeleteGroup.Size = new System.Drawing.Size(210, 184);
            this.ComponentDeleteGroup.TabIndex = 11;
            this.ComponentDeleteGroup.TabStop = false;
            this.ComponentDeleteGroup.Text = "Delete";
            // 
            // EngineSelector
            // 
            this.EngineSelector.FormattingEnabled = true;
            this.EngineSelector.Location = new System.Drawing.Point(66, 71);
            this.EngineSelector.Name = "EngineSelector";
            this.EngineSelector.Size = new System.Drawing.Size(121, 21);
            this.EngineSelector.TabIndex = 10;
            this.EngineSelector.SelectedIndexChanged += new System.EventHandler(this.EngineSelector_SelectedIndexChanged);
            // 
            // BrandSelector
            // 
            this.BrandSelector.FormattingEnabled = true;
            this.BrandSelector.Location = new System.Drawing.Point(66, 18);
            this.BrandSelector.Name = "BrandSelector";
            this.BrandSelector.Size = new System.Drawing.Size(121, 21);
            this.BrandSelector.TabIndex = 11;
            this.BrandSelector.SelectedIndexChanged += new System.EventHandler(this.BrandSelector_SelectedIndexChanged);
            // 
            // TypeSelector
            // 
            this.TypeSelector.FormattingEnabled = true;
            this.TypeSelector.Location = new System.Drawing.Point(66, 45);
            this.TypeSelector.Name = "TypeSelector";
            this.TypeSelector.Size = new System.Drawing.Size(121, 21);
            this.TypeSelector.TabIndex = 12;
            this.TypeSelector.SelectedIndexChanged += new System.EventHandler(this.TypeSelector_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Brand";
            // 
            // Type2
            // 
            this.Type2.AutoSize = true;
            this.Type2.Location = new System.Drawing.Point(20, 48);
            this.Type2.Name = "Type2";
            this.Type2.Size = new System.Drawing.Size(31, 13);
            this.Type2.TabIndex = 14;
            this.Type2.Text = "Type";
            // 
            // Engine2
            // 
            this.Engine2.AutoSize = true;
            this.Engine2.Location = new System.Drawing.Point(20, 74);
            this.Engine2.Name = "Engine2";
            this.Engine2.Size = new System.Drawing.Size(40, 13);
            this.Engine2.TabIndex = 15;
            this.Engine2.Text = "Engine";
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.DataGroup);
            this.Controls.Add(this.LoginGroup);
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.LoginGroup.ResumeLayout(false);
            this.LoginGroup.PerformLayout();
            this.DataGroup.ResumeLayout(false);
            this.VehicleGroup.ResumeLayout(false);
            this.PaintGroup.ResumeLayout(false);
            this.PaintGroup.PerformLayout();
            this.ComponentAddGroup.ResumeLayout(false);
            this.ComponentAddGroup.PerformLayout();
            this.ComponentDeleteGroup.ResumeLayout(false);
            this.ComponentDeleteGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroup;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.GroupBox DataGroup;
        private System.Windows.Forms.GroupBox PaintGroup;
        private System.Windows.Forms.GroupBox VehicleGroup;
        private System.Windows.Forms.Button SendVehicleButton;
        private System.Windows.Forms.Button SendPaintButton;
        private System.Windows.Forms.Label VehicleBrand;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Engine;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.CheckBox MetallicToggle;
        private System.Windows.Forms.TextBox EngineInput;
        private System.Windows.Forms.TextBox TypeInput;
        private System.Windows.Forms.TextBox BrandInput;
        private System.Windows.Forms.TextBox ColorInput;
        private System.Windows.Forms.Button ColorSelector;
        private System.Windows.Forms.Button DeleteVehicleButton;
        private System.Windows.Forms.Button DeletePaintButton;
        private System.Windows.Forms.GroupBox ComponentAddGroup;
        private System.Windows.Forms.GroupBox ComponentDeleteGroup;
        private System.Windows.Forms.ComboBox TypeSelector;
        private System.Windows.Forms.ComboBox BrandSelector;
        private System.Windows.Forms.ComboBox EngineSelector;
        private System.Windows.Forms.Label Engine2;
        private System.Windows.Forms.Label Type2;
        private System.Windows.Forms.Label label3;
    }
}