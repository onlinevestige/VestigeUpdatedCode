namespace POSClient.UI.Controls
{
	partial class ItemSelector
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tlpItemCont = new System.Windows.Forms.TableLayoutPanel();
			this.btnBack = new System.Windows.Forms.Button();
			this.tlpPager = new System.Windows.Forms.TableLayoutPanel();
			this.btnDown = new System.Windows.Forms.Button();
			this.lblPager = new System.Windows.Forms.Label();
			this.btnUp = new System.Windows.Forms.Button();
			this.tlpItemCont.SuspendLayout();
			this.tlpPager.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpItemCont
			// 
			this.tlpItemCont.AutoSize = true;
			this.tlpItemCont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpItemCont.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
			this.tlpItemCont.ColumnCount = 6;
			this.tlpItemCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tlpItemCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tlpItemCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tlpItemCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tlpItemCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tlpItemCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tlpItemCont.Controls.Add(this.btnBack, 4, 2);
			this.tlpItemCont.Controls.Add(this.tlpPager, 5, 0);
			this.tlpItemCont.Location = new System.Drawing.Point(0, 0);
			this.tlpItemCont.Margin = new System.Windows.Forms.Padding(0);
			this.tlpItemCont.Name = "tlpItemCont";
			this.tlpItemCont.RowCount = 3;
			this.tlpItemCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tlpItemCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tlpItemCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tlpItemCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpItemCont.Size = new System.Drawing.Size(434, 218);
			this.tlpItemCont.TabIndex = 0;
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(293, 149);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(64, 64);
			this.btnBack.TabIndex = 3;
			this.btnBack.TabStop = false;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Visible = false;
			this.btnBack.Click += new System.EventHandler(this.ActionButton_Click);
			// 
			// tlpPager
			// 
			this.tlpPager.AutoSize = true;
			this.tlpPager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpPager.ColumnCount = 1;
			this.tlpPager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpPager.Controls.Add(this.btnDown, 0, 2);
			this.tlpPager.Controls.Add(this.lblPager, 0, 1);
			this.tlpPager.Controls.Add(this.btnUp, 0, 0);
			this.tlpPager.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpPager.Location = new System.Drawing.Point(362, 2);
			this.tlpPager.Margin = new System.Windows.Forms.Padding(0);
			this.tlpPager.Name = "tlpPager";
			this.tlpPager.RowCount = 3;
			this.tlpItemCont.SetRowSpan(this.tlpPager, 3);
			this.tlpPager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpPager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpPager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tlpPager.Size = new System.Drawing.Size(70, 214);
			this.tlpPager.TabIndex = 5;
			// 
			// btnDown
			// 
			this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDown.Enabled = false;
			this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDown.Image = global::Plaza.POS.Controls.Properties.Resources.black_down_arrow;
			this.btnDown.Location = new System.Drawing.Point(3, 177);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(64, 34);
			this.btnDown.TabIndex = 2;
			this.btnDown.TabStop = false;
			this.btnDown.UseVisualStyleBackColor = false;
			this.btnDown.Click += new System.EventHandler(this.ActionButton_Click);
			// 
			// lblPager
			// 
			this.lblPager.AutoSize = true;
			this.lblPager.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPager.Location = new System.Drawing.Point(3, 40);
			this.lblPager.Name = "lblPager";
			this.lblPager.Size = new System.Drawing.Size(64, 134);
			this.lblPager.TabIndex = 4;
			this.lblPager.Text = "0/0";
			this.lblPager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnUp
			// 
			this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnUp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnUp.Enabled = false;
			this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUp.Image = global::Plaza.POS.Controls.Properties.Resources.black_up_arrow;
			this.btnUp.Location = new System.Drawing.Point(3, 3);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(64, 34);
			this.btnUp.TabIndex = 1;
			this.btnUp.TabStop = false;
			this.btnUp.UseVisualStyleBackColor = false;
			this.btnUp.Click += new System.EventHandler(this.ActionButton_Click);
			// 
			// ItemSelector
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.tlpItemCont);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ItemSelector";
			this.Size = new System.Drawing.Size(434, 217);
			this.tlpItemCont.ResumeLayout(false);
			this.tlpItemCont.PerformLayout();
			this.tlpPager.ResumeLayout(false);
			this.tlpPager.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpItemCont;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label lblPager;
		private System.Windows.Forms.TableLayoutPanel tlpPager;
	}
}
