namespace Bakery
{
    partial class OpeningForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Бородинский хлеб");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ржаной хлеб");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Хлеб", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Сметанник");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Королевская ватрушка");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Десерты", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Кыстыбый");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Национальна кухня", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.Picture_Of_Baker = new System.Windows.Forms.PictureBox();
            this.Tree_Of_Dishes = new System.Windows.Forms.TreeView();
            this.Download_btn = new System.Windows.Forms.Button();
            this.Show_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Download_File = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Of_Baker)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Of_Baker
            // 
            this.Picture_Of_Baker.Image = ((System.Drawing.Image)(resources.GetObject("Picture_Of_Baker.Image")));
            this.Picture_Of_Baker.InitialImage = null;
            this.Picture_Of_Baker.Location = new System.Drawing.Point(12, 12);
            this.Picture_Of_Baker.Name = "Picture_Of_Baker";
            this.Picture_Of_Baker.Size = new System.Drawing.Size(130, 130);
            this.Picture_Of_Baker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Of_Baker.TabIndex = 0;
            this.Picture_Of_Baker.TabStop = false;
            // 
            // Tree_Of_Dishes
            // 
            this.Tree_Of_Dishes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tree_Of_Dishes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tree_Of_Dishes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tree_Of_Dishes.Location = new System.Drawing.Point(12, 157);
            this.Tree_Of_Dishes.Name = "Tree_Of_Dishes";
            treeNode1.Name = "Бородинский";
            treeNode1.Text = "Бородинский хлеб";
            treeNode2.Name = "Ржаной ";
            treeNode2.Text = "Ржаной хлеб";
            treeNode3.Name = "Хлеб";
            treeNode3.Text = "Хлеб";
            treeNode4.Name = "Сметанник ";
            treeNode4.Text = "Сметанник";
            treeNode5.Name = "Королевская ватрушка";
            treeNode5.Text = "Королевская ватрушка";
            treeNode6.Name = "Десерты";
            treeNode6.Text = "Десерты";
            treeNode7.Name = "Кыстыбый";
            treeNode7.Text = "Кыстыбый";
            treeNode8.Name = "Нац кухня";
            treeNode8.Text = "Национальна кухня";
            this.Tree_Of_Dishes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode8});
            this.Tree_Of_Dishes.Size = new System.Drawing.Size(215, 252);
            this.Tree_Of_Dishes.TabIndex = 1;
            // 
            // Download_btn
            // 
            this.Download_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Download_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Download_btn.FlatAppearance.BorderSize = 0;
            this.Download_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Download_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Download_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Download_btn.Location = new System.Drawing.Point(233, 12);
            this.Download_btn.Name = "Download_btn";
            this.Download_btn.Size = new System.Drawing.Size(135, 50);
            this.Download_btn.TabIndex = 2;
            this.Download_btn.Text = "Загрузить";
            this.Download_btn.UseVisualStyleBackColor = true;
            this.Download_btn.Click += new System.EventHandler(this.DownloadFile);
            // 
            // Show_btn
            // 
            this.Show_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_btn.Location = new System.Drawing.Point(377, 12);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(135, 50);
            this.Show_btn.TabIndex = 3;
            this.Show_btn.Text = "Показать ";
            this.Show_btn.UseVisualStyleBackColor = true;
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Close_btn.Image = ((System.Drawing.Image)(resources.GetObject("Close_btn.Image")));
            this.Close_btn.Location = new System.Drawing.Point(712, 17);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(50, 45);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.CloseAnApp);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(222, -110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(5, 700);
            this.label1.TabIndex = 5;
            // 
            // Download_File
            // 
            this.Download_File.FileName = "Dowmload_File";
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.Download_btn);
            this.Controls.Add(this.Tree_Of_Dishes);
            this.Controls.Add(this.Picture_Of_Baker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(790, 545);
            this.Name = "OpeningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Of_Baker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Of_Baker;
        private System.Windows.Forms.TreeView Tree_Of_Dishes;
        private System.Windows.Forms.Button Download_btn;
        private System.Windows.Forms.Button Show_btn;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog Download_File;
    }
}

