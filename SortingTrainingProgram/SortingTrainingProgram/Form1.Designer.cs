namespace SortingTrainingProgram
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnShaker = new System.Windows.Forms.Button();
            this.btn_gnome_sort = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.algPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.algName = new System.Windows.Forms.Label();
            this.AlgPanel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.panelMenu.Controls.Add(this.btnShaker);
            this.panelMenu.Controls.Add(this.btn_gnome_sort);
            this.panelMenu.Controls.Add(this.btnBubble);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 680);
            this.panelMenu.TabIndex = 10;
            // 
            // btnShaker
            // 
            this.btnShaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShaker.FlatAppearance.BorderSize = 0;
            this.btnShaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShaker.ForeColor = System.Drawing.Color.IndianRed;
            this.btnShaker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShaker.Location = new System.Drawing.Point(0, 150);
            this.btnShaker.Name = "btnShaker";
            this.btnShaker.Size = new System.Drawing.Size(200, 50);
            this.btnShaker.TabIndex = 3;
            this.btnShaker.Text = "Shaker Sort";
            this.btnShaker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShaker.UseVisualStyleBackColor = true;
            this.btnShaker.Click += new System.EventHandler(this.btnShaker_Click);
            // 
            // btn_gnome_sort
            // 
            this.btn_gnome_sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gnome_sort.FlatAppearance.BorderSize = 0;
            this.btn_gnome_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gnome_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_gnome_sort.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_gnome_sort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gnome_sort.Location = new System.Drawing.Point(0, 200);
            this.btn_gnome_sort.Name = "btn_gnome_sort";
            this.btn_gnome_sort.Size = new System.Drawing.Size(200, 50);
            this.btn_gnome_sort.TabIndex = 2;
            this.btn_gnome_sort.Text = "Gnome Sort";
            this.btn_gnome_sort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gnome_sort.UseVisualStyleBackColor = true;
            this.btn_gnome_sort.Click += new System.EventHandler(this.btn_gnome_sort_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBubble.FlatAppearance.BorderSize = 0;
            this.btnBubble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBubble.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBubble.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBubble.Location = new System.Drawing.Point(0, 100);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(200, 50);
            this.btnBubble.TabIndex = 0;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // algPanel
            // 
            this.algPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.algPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(167)))));
            this.algPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.algPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.algPanel.Location = new System.Drawing.Point(0, 0);
            this.algPanel.Name = "algPanel";
            this.algPanel.Size = new System.Drawing.Size(935, 584);
            this.algPanel.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(160)))), ((int)(((byte)(142)))));
            this.panel2.Controls.Add(this.algName);
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 100);
            this.panel2.TabIndex = 13;
            // 
            // algName
            // 
            this.algName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.algName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algName.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.algName.Location = new System.Drawing.Point(6, 27);
            this.algName.Name = "algName";
            this.algName.Size = new System.Drawing.Size(968, 53);
            this.algName.TabIndex = 0;
            this.algName.Text = "Якийсь там алгоритм";
            // 
            // AlgPanel1
            // 
            this.AlgPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlgPanel1.Location = new System.Drawing.Point(200, 100);
            this.AlgPanel1.Name = "AlgPanel1";
            this.AlgPanel1.Size = new System.Drawing.Size(1106, 581);
            this.AlgPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(204)))), ((int)(((byte)(127)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1255, 681);
            this.Controls.Add(this.AlgPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vadim cyc\'ka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_gnome_sort;
        private System.Windows.Forms.Button btnShaker;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Panel algPanel;
        private System.Windows.Forms.Label algName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel AlgPanel1;
    }
}

