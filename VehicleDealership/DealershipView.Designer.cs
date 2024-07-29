namespace VehicleDealership
{

    partial class DealershipView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DealershipView));
            this.BrandSelector = new System.Windows.Forms.ComboBox();
            this.VehicleBrand = new System.Windows.Forms.Label();
            this.TypeSelector = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.Label();
            this.EngineSelector = new System.Windows.Forms.ComboBox();
            this.Engine = new System.Windows.Forms.Label();
            this.MetallicToggle = new System.Windows.Forms.CheckBox();
            this.ComponentsGroup = new System.Windows.Forms.GroupBox();
            this.PaintGroup = new System.Windows.Forms.GroupBox();
            this.Color = new System.Windows.Forms.Label();
            this.ColorSelector = new System.Windows.Forms.ComboBox();
            this.BasicsGroup = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dealershipDatabaseDataSet = new VehicleDealership.DealershipDatabaseDataSet();
            this.dealershipDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealershipDataTableAdapter = new VehicleDealership.DealershipDatabaseDataSetTableAdapters.DealershipDataTableAdapter();
            this.dealershipDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AdminPanel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ComponentsGroup.SuspendLayout();
            this.PaintGroup.SuspendLayout();
            this.BasicsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandSelector
            // 
            this.BrandSelector.FormattingEnabled = true;
            this.BrandSelector.Location = new System.Drawing.Point(54, 29);
            this.BrandSelector.Name = "BrandSelector";
            this.BrandSelector.Size = new System.Drawing.Size(121, 21);
            this.BrandSelector.TabIndex = 0;
            this.BrandSelector.SelectedIndexChanged += new System.EventHandler(this.BrandSelector_SelectedIndexChanged);
            // 
            // VehicleBrand
            // 
            this.VehicleBrand.AutoSize = true;
            this.VehicleBrand.Location = new System.Drawing.Point(13, 32);
            this.VehicleBrand.Name = "VehicleBrand";
            this.VehicleBrand.Size = new System.Drawing.Size(35, 13);
            this.VehicleBrand.TabIndex = 1;
            this.VehicleBrand.Text = "Brand";
            // 
            // TypeSelector
            // 
            this.TypeSelector.FormattingEnabled = true;
            this.TypeSelector.Location = new System.Drawing.Point(54, 56);
            this.TypeSelector.Name = "TypeSelector";
            this.TypeSelector.Size = new System.Drawing.Size(121, 21);
            this.TypeSelector.TabIndex = 2;
            this.TypeSelector.SelectedIndexChanged += new System.EventHandler(this.TypeSelector_SelectedIndexChanged);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(17, 59);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 3;
            this.Type.Text = "Type";
            // 
            // EngineSelector
            // 
            this.EngineSelector.FormattingEnabled = true;
            this.EngineSelector.Location = new System.Drawing.Point(60, 28);
            this.EngineSelector.Name = "EngineSelector";
            this.EngineSelector.Size = new System.Drawing.Size(121, 21);
            this.EngineSelector.TabIndex = 0;
            this.EngineSelector.SelectedIndexChanged += new System.EventHandler(this.EngineSelector_SelectedIndexChanged);
            // 
            // Engine
            // 
            this.Engine.AutoSize = true;
            this.Engine.Location = new System.Drawing.Point(14, 31);
            this.Engine.Name = "Engine";
            this.Engine.Size = new System.Drawing.Size(40, 13);
            this.Engine.TabIndex = 1;
            this.Engine.Text = "Engine";
            // 
            // MetallicToggle
            // 
            this.MetallicToggle.AutoSize = true;
            this.MetallicToggle.Location = new System.Drawing.Point(10, 55);
            this.MetallicToggle.Name = "MetallicToggle";
            this.MetallicToggle.Size = new System.Drawing.Size(62, 17);
            this.MetallicToggle.TabIndex = 2;
            this.MetallicToggle.Text = "Metallic";
            this.MetallicToggle.UseVisualStyleBackColor = true;
            this.MetallicToggle.CheckedChanged += new System.EventHandler(this.MetallicToggle_CheckedChanged);
            // 
            // ComponentsGroup
            // 
            this.ComponentsGroup.Controls.Add(this.Engine);
            this.ComponentsGroup.Controls.Add(this.EngineSelector);
            this.ComponentsGroup.Location = new System.Drawing.Point(218, 12);
            this.ComponentsGroup.Name = "ComponentsGroup";
            this.ComponentsGroup.Size = new System.Drawing.Size(200, 100);
            this.ComponentsGroup.TabIndex = 2;
            this.ComponentsGroup.TabStop = false;
            this.ComponentsGroup.Text = "Components";
            // 
            // PaintGroup
            // 
            this.PaintGroup.Controls.Add(this.Color);
            this.PaintGroup.Controls.Add(this.ColorSelector);
            this.PaintGroup.Controls.Add(this.MetallicToggle);
            this.PaintGroup.Location = new System.Drawing.Point(424, 12);
            this.PaintGroup.Name = "PaintGroup";
            this.PaintGroup.Size = new System.Drawing.Size(178, 100);
            this.PaintGroup.TabIndex = 5;
            this.PaintGroup.TabStop = false;
            this.PaintGroup.Text = "Paint";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(7, 32);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(31, 13);
            this.Color.TabIndex = 4;
            this.Color.Text = "Color";
            // 
            // ColorSelector
            // 
            this.ColorSelector.FormattingEnabled = true;
            this.ColorSelector.Location = new System.Drawing.Point(44, 28);
            this.ColorSelector.Name = "ColorSelector";
            this.ColorSelector.Size = new System.Drawing.Size(121, 21);
            this.ColorSelector.TabIndex = 3;
            this.ColorSelector.SelectedIndexChanged += new System.EventHandler(this.ColorSelector_SelectedIndexChanged);
            // 
            // BasicsGroup
            // 
            this.BasicsGroup.Controls.Add(this.BrandSelector);
            this.BasicsGroup.Controls.Add(this.Type);
            this.BasicsGroup.Controls.Add(this.TypeSelector);
            this.BasicsGroup.Controls.Add(this.VehicleBrand);
            this.BasicsGroup.Location = new System.Drawing.Point(12, 12);
            this.BasicsGroup.Name = "BasicsGroup";
            this.BasicsGroup.Size = new System.Drawing.Size(200, 100);
            this.BasicsGroup.TabIndex = 2;
            this.BasicsGroup.TabStop = false;
            this.BasicsGroup.Text = "Basics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VehicleDealership.Properties.Resources.Wallpaper;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dealershipDatabaseDataSet
            // 
            this.dealershipDatabaseDataSet.DataSetName = "DealershipDatabaseDataSet";
            this.dealershipDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dealershipDataBindingSource
            // 
            this.dealershipDataBindingSource.DataMember = "DealershipData";
            this.dealershipDataBindingSource.DataSource = this.dealershipDatabaseDataSet;
            // 
            // dealershipDataTableAdapter
            // 
            this.dealershipDataTableAdapter.ClearBeforeFill = true;
            // 
            // dealershipDataBindingSource1
            // 
            this.dealershipDataBindingSource1.DataMember = "DealershipData";
            this.dealershipDataBindingSource1.DataSource = this.dealershipDatabaseDataSet;
            // 
            // AdminPanel
            // 
            this.AdminPanel.Location = new System.Drawing.Point(535, 533);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(75, 23);
            this.AdminPanel.TabIndex = 7;
            this.AdminPanel.Text = "Admin";
            this.AdminPanel.UseVisualStyleBackColor = true;
            this.AdminPanel.Click += new System.EventHandler(this.AdminPanel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DealershipView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(622, 568);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BasicsGroup);
            this.Controls.Add(this.PaintGroup);
            this.Controls.Add(this.ComponentsGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DealershipView";
            this.Text = "Olga\'s Vehicle Dealership";
            this.Load += new System.EventHandler(this.DealershipView_Load);
            this.ComponentsGroup.ResumeLayout(false);
            this.ComponentsGroup.PerformLayout();
            this.PaintGroup.ResumeLayout(false);
            this.PaintGroup.PerformLayout();
            this.BasicsGroup.ResumeLayout(false);
            this.BasicsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipDataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox BrandSelector;
        private System.Windows.Forms.Label VehicleBrand;
        private System.Windows.Forms.ComboBox TypeSelector;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.ComboBox EngineSelector;
        private System.Windows.Forms.CheckBox MetallicToggle;
        private System.Windows.Forms.Label Engine;
        private System.Windows.Forms.GroupBox ComponentsGroup;
        private System.Windows.Forms.GroupBox PaintGroup;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.ComboBox ColorSelector;
        private System.Windows.Forms.GroupBox BasicsGroup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DealershipDatabaseDataSet dealershipDatabaseDataSet;
        private System.Windows.Forms.BindingSource dealershipDataBindingSource;
        private DealershipDatabaseDataSetTableAdapters.DealershipDataTableAdapter dealershipDataTableAdapter;
        private System.Windows.Forms.BindingSource dealershipDataBindingSource1;
        private System.Windows.Forms.Button AdminPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

