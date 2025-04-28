
namespace var6._1_kirichenkoilya
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
            this.components = new System.ComponentModel.Container();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.listViewIndex = new System.Windows.Forms.ListView();
            this.Слово = new System.Windows.Forms.ColumnHeader();
            this.Страницы = new System.Windows.Forms.ColumnHeader();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.txtPage);
            this.panelTop.Controls.Add(this.txtWord);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10);
            this.panelTop.Size = new System.Drawing.Size(605, 160);
            this.panelTop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите страницу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите слово";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(359, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPage
            // 
            this.txtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPage.Location = new System.Drawing.Point(166, 97);
            this.txtPage.Name = "txtPage";
            this.txtPage.PlaceholderText = "Страница";
            this.txtPage.Size = new System.Drawing.Size(100, 23);
            this.txtPage.TabIndex = 3;
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.Location = new System.Drawing.Point(150, 46);
            this.txtWord.Name = "txtWord";
            this.txtWord.PlaceholderText = "Введите слово";
            this.txtWord.Size = new System.Drawing.Size(116, 23);
            this.txtWord.TabIndex = 2;
            // 
            // listViewIndex
            // 
            this.listViewIndex.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Слово,
            this.Страницы});
            this.listViewIndex.ContextMenuStrip = this.contextMenu;
            this.listViewIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewIndex.FullRowSelect = true;
            this.listViewIndex.GridLines = true;
            this.listViewIndex.HideSelection = false;
            this.listViewIndex.Location = new System.Drawing.Point(0, 160);
            this.listViewIndex.Name = "listViewIndex";
            this.listViewIndex.Size = new System.Drawing.Size(605, 290);
            this.listViewIndex.TabIndex = 2;
            this.listViewIndex.UseCompatibleStateImageBehavior = false;
            this.listViewIndex.View = System.Windows.Forms.View.Details;
            this.listViewIndex.SelectedIndexChanged += new System.EventHandler(this.listViewIndex_SelectedIndexChanged);
            // 
            // Слово
            // 
            this.Слово.Text = "Слово";
            this.Слово.Width = 300;
            // 
            // Страницы
            // 
            this.Страницы.Text = "Страницы";
            this.Страницы.Width = 350;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.listViewIndex);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.ListView listViewIndex;
        private System.Windows.Forms.ColumnHeader Слово;
        private System.Windows.Forms.ColumnHeader Страницы;
    }
}

