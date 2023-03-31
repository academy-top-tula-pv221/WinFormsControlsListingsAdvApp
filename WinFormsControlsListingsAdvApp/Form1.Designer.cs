namespace WinFormsControlsListingsAdvApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListViewItem listViewItem1 = new ListViewItem("Калуга", 0);
            ListViewItem listViewItem2 = new ListViewItem("Москва", 1);
            ListViewItem listViewItem3 = new ListViewItem("Санкт Петербург", 2);
            ListViewItem listViewItem4 = new ListViewItem("Тула", 3);
            ListViewItem listViewItem5 = new ListViewItem("Воронеж", 4);
            TreeNode treeNode1 = new TreeNode("Стиральные машины");
            TreeNode treeNode2 = new TreeNode("Холодильники");
            TreeNode treeNode3 = new TreeNode("Бытовая техника", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Ноутбуки");
            TreeNode treeNode5 = new TreeNode("Компьютеры", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Товары", new TreeNode[] { treeNode3, treeNode5 });
            checkedListBox1 = new CheckedListBox();
            imgListCities = new ImageList(components);
            lstViewCities = new ListView();
            lblCities = new Label();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            btnExpand = new Button();
            btnCollapse = new Button();
            btnExpandAll = new Button();
            numericUpDown1 = new NumericUpDown();
            domainUpDown1 = new DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "C++", "C#", "Java", "PHP", "JavaScript", "Python" });
            checkedListBox1.Location = new Point(643, 308);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(145, 130);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // imgListCities
            // 
            imgListCities.ColorDepth = ColorDepth.Depth8Bit;
            imgListCities.ImageStream = (ImageListStreamer)resources.GetObject("imgListCities.ImageStream");
            imgListCities.TransparentColor = Color.Transparent;
            imgListCities.Images.SetKeyName(0, "kaluga.png");
            imgListCities.Images.SetKeyName(1, "moscow.png");
            imgListCities.Images.SetKeyName(2, "st-peterburg.png");
            imgListCities.Images.SetKeyName(3, "tula.png");
            imgListCities.Images.SetKeyName(4, "voroneg.png");
            // 
            // lstViewCities
            // 
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            lstViewCities.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            lstViewCities.LargeImageList = imgListCities;
            lstViewCities.Location = new Point(455, 12);
            lstViewCities.Name = "lstViewCities";
            lstViewCities.Size = new Size(333, 227);
            lstViewCities.SmallImageList = imgListCities;
            lstViewCities.TabIndex = 1;
            lstViewCities.UseCompatibleStateImageBehavior = false;
            lstViewCities.View = View.Tile;
            // 
            // lblCities
            // 
            lblCities.AutoSize = true;
            lblCities.Location = new Point(24, 7);
            lblCities.Name = "lblCities";
            lblCities.Size = new Size(49, 15);
            lblCities.TabIndex = 2;
            lblCities.Text = "Города:";
            // 
            // treeView1
            // 
            treeView1.CheckBoxes = true;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(24, 25);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "Стиральные машины";
            treeNode2.Name = "Узел4";
            treeNode2.Text = "Холодильники";
            treeNode3.Name = "Узел1";
            treeNode3.Text = "Бытовая техника";
            treeNode4.Name = "Узел5";
            treeNode4.Text = "Ноутбуки";
            treeNode5.Name = "Узел2";
            treeNode5.Text = "Компьютеры";
            treeNode6.Name = "Узел0";
            treeNode6.Text = "Товары";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode6 });
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(263, 214);
            treeView1.TabIndex = 3;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder.png");
            // 
            // btnExpand
            // 
            btnExpand.Location = new Point(310, 25);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(104, 23);
            btnExpand.TabIndex = 4;
            btnExpand.Text = "Expand";
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // btnCollapse
            // 
            btnCollapse.Location = new Point(310, 118);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(104, 23);
            btnCollapse.TabIndex = 4;
            btnCollapse.Text = "Collapse";
            btnCollapse.UseVisualStyleBackColor = true;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // btnExpandAll
            // 
            btnExpandAll.Location = new Point(310, 72);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new Size(104, 23);
            btnExpandAll.TabIndex = 4;
            btnExpandAll.Text = "Expand All";
            btnExpandAll.UseVisualStyleBackColor = true;
            btnExpandAll.Click += btnExpandAll_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(24, 297);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(263, 36);
            numericUpDown1.TabIndex = 5;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            domainUpDown1.Items.Add("Россия");
            domainUpDown1.Items.Add("Беларуссия");
            domainUpDown1.Items.Add("Армения");
            domainUpDown1.Items.Add("Азербайджан");
            domainUpDown1.Items.Add("Турция");
            domainUpDown1.Items.Add("Китай");
            domainUpDown1.Location = new Point(24, 356);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(263, 36);
            domainUpDown1.TabIndex = 6;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(domainUpDown1);
            Controls.Add(numericUpDown1);
            Controls.Add(btnCollapse);
            Controls.Add(btnExpandAll);
            Controls.Add(btnExpand);
            Controls.Add(treeView1);
            Controls.Add(lblCities);
            Controls.Add(lstViewCities);
            Controls.Add(checkedListBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private ImageList imgListCities;
        private ListView lstViewCities;
        private Label lblCities;
        private TreeView treeView1;
        private ImageList imageList1;
        private Button btnExpand;
        private Button btnCollapse;
        private Button btnExpandAll;
        private NumericUpDown numericUpDown1;
        private DomainUpDown domainUpDown1;
    }
}