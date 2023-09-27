namespace LAB5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            FoodListgroupBox1 = new GroupBox();
            Nuibutton = new Button();
            ComSuonbutton = new Button();
            BanhCanhbutton = new Button();
            ComTambutton = new Button();
            Phobutton = new Button();
            Cerealbutton = new Button();
            Bunbutton = new Button();
            Breadbutton = new Button();
            Orderbutton = new Button();
            Deletebutton = new Button();
            ShowOrderdataGridView1 = new DataGridView();
            ChoseTablecomboBox1 = new ComboBox();
            ChoseTablelabel1 = new Label();
            RemoveSelectedFoodButton = new Button();
            foodNameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            FoodListgroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowOrderdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FoodListgroupBox1
            // 
            FoodListgroupBox1.Controls.Add(Nuibutton);
            FoodListgroupBox1.Controls.Add(ComSuonbutton);
            FoodListgroupBox1.Controls.Add(BanhCanhbutton);
            FoodListgroupBox1.Controls.Add(ComTambutton);
            FoodListgroupBox1.Controls.Add(Phobutton);
            FoodListgroupBox1.Controls.Add(Cerealbutton);
            FoodListgroupBox1.Controls.Add(Bunbutton);
            FoodListgroupBox1.Controls.Add(Breadbutton);
            FoodListgroupBox1.Location = new Point(1, 86);
            FoodListgroupBox1.Name = "FoodListgroupBox1";
            FoodListgroupBox1.Size = new Size(795, 180);
            FoodListgroupBox1.TabIndex = 2;
            FoodListgroupBox1.TabStop = false;
            FoodListgroupBox1.Text = "Food List";
            // 
            // Nuibutton
            // 
            Nuibutton.Location = new Point(655, 121);
            Nuibutton.Name = "Nuibutton";
            Nuibutton.Size = new Size(116, 53);
            Nuibutton.TabIndex = 7;
            Nuibutton.Text = "Nui";
            Nuibutton.UseVisualStyleBackColor = true;
            Nuibutton.Click += Nuibutton_Click;
            // 
            // ComSuonbutton
            // 
            ComSuonbutton.Location = new Point(460, 121);
            ComSuonbutton.Name = "ComSuonbutton";
            ComSuonbutton.Size = new Size(116, 53);
            ComSuonbutton.TabIndex = 6;
            ComSuonbutton.Text = "Com Suon";
            ComSuonbutton.UseVisualStyleBackColor = true;
            ComSuonbutton.Click += ComSuonbutton_Click;
            // 
            // BanhCanhbutton
            // 
            BanhCanhbutton.Location = new Point(258, 121);
            BanhCanhbutton.Name = "BanhCanhbutton";
            BanhCanhbutton.Size = new Size(116, 53);
            BanhCanhbutton.TabIndex = 5;
            BanhCanhbutton.Text = "Banh Canh";
            BanhCanhbutton.UseVisualStyleBackColor = true;
            BanhCanhbutton.Click += BanhCanhbutton_Click;
            // 
            // ComTambutton
            // 
            ComTambutton.Location = new Point(66, 121);
            ComTambutton.Name = "ComTambutton";
            ComTambutton.Size = new Size(116, 53);
            ComTambutton.TabIndex = 4;
            ComTambutton.Text = "Com Tam";
            ComTambutton.UseVisualStyleBackColor = true;
            ComTambutton.Click += ComTambutton_Click;
            // 
            // Phobutton
            // 
            Phobutton.Location = new Point(655, 26);
            Phobutton.Name = "Phobutton";
            Phobutton.Size = new Size(116, 53);
            Phobutton.TabIndex = 3;
            Phobutton.Text = "Pho";
            Phobutton.UseVisualStyleBackColor = true;
            Phobutton.Click += Phobutton_Click;
            // 
            // Cerealbutton
            // 
            Cerealbutton.Location = new Point(258, 26);
            Cerealbutton.Name = "Cerealbutton";
            Cerealbutton.Size = new Size(116, 53);
            Cerealbutton.TabIndex = 2;
            Cerealbutton.Text = "Cereals";
            Cerealbutton.UseVisualStyleBackColor = true;
            Cerealbutton.Click += Cerealbutton_Click;
            // 
            // Bunbutton
            // 
            Bunbutton.Location = new Point(460, 26);
            Bunbutton.Name = "Bunbutton";
            Bunbutton.Size = new Size(116, 53);
            Bunbutton.TabIndex = 1;
            Bunbutton.Text = "Bun";
            Bunbutton.UseVisualStyleBackColor = true;
            Bunbutton.Click += Bunbutton_Click;
            // 
            // Breadbutton
            // 
            Breadbutton.Location = new Point(66, 26);
            Breadbutton.Name = "Breadbutton";
            Breadbutton.Size = new Size(116, 53);
            Breadbutton.TabIndex = 0;
            Breadbutton.Text = "Breads";
            Breadbutton.UseVisualStyleBackColor = true;
            Breadbutton.Click += Breadbutton_Click;
            // 
            // Orderbutton
            // 
            Orderbutton.Location = new Point(876, 333);
            Orderbutton.Name = "Orderbutton";
            Orderbutton.Size = new Size(139, 45);
            Orderbutton.TabIndex = 4;
            Orderbutton.Text = "Order";
            Orderbutton.UseVisualStyleBackColor = true;
            Orderbutton.Click += Orderbutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(876, 422);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(139, 45);
            Deletebutton.TabIndex = 5;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // ShowOrderdataGridView1
            // 
            ShowOrderdataGridView1.AllowUserToAddRows = false;
            ShowOrderdataGridView1.AllowUserToDeleteRows = false;
            ShowOrderdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowOrderdataGridView1.Location = new Point(99, 360);
            ShowOrderdataGridView1.Name = "ShowOrderdataGridView1";
            ShowOrderdataGridView1.ReadOnly = true;
            ShowOrderdataGridView1.RowHeadersWidth = 51;
            ShowOrderdataGridView1.RowTemplate.Height = 29;
            ShowOrderdataGridView1.Size = new Size(583, 277);
            ShowOrderdataGridView1.TabIndex = 6;
            // 
            // ChoseTablecomboBox1
            // 
            ChoseTablecomboBox1.FormattingEnabled = true;
            ChoseTablecomboBox1.Location = new Point(876, 269);
            ChoseTablecomboBox1.Name = "ChoseTablecomboBox1";
            ChoseTablecomboBox1.Size = new Size(151, 28);
            ChoseTablecomboBox1.TabIndex = 7;
            ChoseTablecomboBox1.SelectedIndexChanged += ChosecomboBox1_SelectedIndexChanged;
            // 
            // ChoseTablelabel1
            // 
            ChoseTablelabel1.AutoSize = true;
            ChoseTablelabel1.Location = new Point(923, 246);
            ChoseTablelabel1.Name = "ChoseTablelabel1";
            ChoseTablelabel1.Size = new Size(44, 20);
            ChoseTablelabel1.TabIndex = 8;
            ChoseTablelabel1.Text = "Table";
            // 
            // RemoveSelectedFoodButton
            // 
            RemoveSelectedFoodButton.Location = new Point(883, 507);
            RemoveSelectedFoodButton.Name = "RemoveSelectedFoodButton";
            RemoveSelectedFoodButton.Size = new Size(132, 42);
            RemoveSelectedFoodButton.TabIndex = 9;
            RemoveSelectedFoodButton.Text = "Remove";
            RemoveSelectedFoodButton.UseVisualStyleBackColor = true;
            RemoveSelectedFoodButton.Click += RemoveSelectedFoodButton_Click;
            // 
            // foodNameTextBox
            // 
            foodNameTextBox.Location = new Point(883, 569);
            foodNameTextBox.Name = "foodNameTextBox";
            foodNameTextBox.Size = new Size(125, 27);
            foodNameTextBox.TabIndex = 10;
            foodNameTextBox.TextChanged += foodNameTextBox_TextChanged;
            foodNameTextBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 671);
            Controls.Add(foodNameTextBox);
            Controls.Add(RemoveSelectedFoodButton);
            Controls.Add(ChoseTablelabel1);
            Controls.Add(ChoseTablecomboBox1);
            Controls.Add(ShowOrderdataGridView1);
            Controls.Add(Deletebutton);
            Controls.Add(Orderbutton);
            Controls.Add(FoodListgroupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            FoodListgroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ShowOrderdataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox FoodListgroupBox1;
        private Button Nuibutton;
        private Button ComSuonbutton;
        private Button BanhCanhbutton;
        private Button ComTambutton;
        private Button Phobutton;
        private Button Cerealbutton;
        private Button Bunbutton;
        private Button Breadbutton;
        private Button Orderbutton;
        private Button Deletebutton;
        private DataGridView ShowOrderdataGridView1;
        private ComboBox ChoseTablecomboBox1;
        private Label ChoseTablelabel1;
        private Button RemoveSelectedFoodButton;
        private TextBox foodNameTextBox;
    }
}