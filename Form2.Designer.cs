
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.금일판매량ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.금일판매량우수메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.금일판매량ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.메뉴관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출결산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.금일판매량ToolStripMenuItem,
            this.금일판매량우수메뉴ToolStripMenuItem,
            this.금일판매량ToolStripMenuItem1,
            this.메뉴관리ToolStripMenuItem,
            this.매출결산ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 금일판매량ToolStripMenuItem
            // 
            this.금일판매량ToolStripMenuItem.Name = "금일판매량ToolStripMenuItem";
            this.금일판매량ToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.금일판매량ToolStripMenuItem.Text = "전체 메뉴 결산 ";
            this.금일판매량ToolStripMenuItem.Click += new System.EventHandler(this.금일판매량ToolStripMenuItem_Click);
            // 
            // 금일판매량우수메뉴ToolStripMenuItem
            // 
            this.금일판매량우수메뉴ToolStripMenuItem.Name = "금일판매량우수메뉴ToolStripMenuItem";
            this.금일판매량우수메뉴ToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.금일판매량우수메뉴ToolStripMenuItem.Text = "금일 판매량 우수 메뉴";
            // 
            // 금일판매량ToolStripMenuItem1
            // 
            this.금일판매량ToolStripMenuItem1.Name = "금일판매량ToolStripMenuItem1";
            this.금일판매량ToolStripMenuItem1.Size = new System.Drawing.Size(139, 20);
            this.금일판매량ToolStripMenuItem1.Text = "금일 판매량 미달 메뉴";
            this.금일판매량ToolStripMenuItem1.Click += new System.EventHandler(this.금일판매량ToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(925, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "현재시각";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(378, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "메뉴 결산";
            // 
            // 메뉴관리ToolStripMenuItem
            // 
            this.메뉴관리ToolStripMenuItem.Name = "메뉴관리ToolStripMenuItem";
            this.메뉴관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.메뉴관리ToolStripMenuItem.Text = "메뉴 관리";
            // 
            // 매출결산ToolStripMenuItem
            // 
            this.매출결산ToolStripMenuItem.Name = "매출결산ToolStripMenuItem";
            this.매출결산ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.매출결산ToolStripMenuItem.Text = "매출 결산";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "메뉴결산";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 금일판매량ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 금일판매량우수메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 금일판매량ToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출결산ToolStripMenuItem;
    }
}