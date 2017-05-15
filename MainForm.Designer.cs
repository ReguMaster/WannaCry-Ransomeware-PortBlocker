namespace WannaCry_FirewallManager
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.authorLabel = new System.Windows.Forms.Label();
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.PATCHED_LABEL = new System.Windows.Forms.Label();
			this.PATCHED_IMAGE = new System.Windows.Forms.PictureBox();
			this.LOGO = new System.Windows.Forms.PictureBox();
			this.MINIMIZE_BUTTON = new WannaCry_FirewallManager.FlatImageButton();
			this.APP_TITLE = new WannaCry_FirewallManager.CustomLabel();
			this.CLOSE_BUTTON = new WannaCry_FirewallManager.FlatImageButton();
			this.EXECUTE_PORT_BLOCK_BUTTON = new WannaCry_FirewallManager.FlatButton();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PATCHED_IMAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MINIMIZE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			this.SuspendLayout();
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.authorLabel.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.authorLabel.Location = new System.Drawing.Point(304, 228);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(44, 13);
			this.authorLabel.TabIndex = 0;
			this.authorLabel.Text = "by L7D";
			this.authorLabel.Click += new System.EventHandler(this.authorLabel_Click);
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.White;
			this.APP_TITLE_BAR.Controls.Add(this.MINIMIZE_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.APP_TITLE);
			this.APP_TITLE_BAR.Controls.Add(this.CLOSE_BUTTON);
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(360, 30);
			this.APP_TITLE_BAR.TabIndex = 4;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			// 
			// PATCHED_LABEL
			// 
			this.PATCHED_LABEL.AutoSize = true;
			this.PATCHED_LABEL.Cursor = System.Windows.Forms.Cursors.Default;
			this.PATCHED_LABEL.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PATCHED_LABEL.Location = new System.Drawing.Point(43, 219);
			this.PATCHED_LABEL.Name = "PATCHED_LABEL";
			this.PATCHED_LABEL.Size = new System.Drawing.Size(150, 13);
			this.PATCHED_LABEL.TabIndex = 5;
			this.PATCHED_LABEL.Text = "보안 패치가 설치되었습니다.";
			// 
			// PATCHED_IMAGE
			// 
			this.PATCHED_IMAGE.BackColor = System.Drawing.Color.Transparent;
			this.PATCHED_IMAGE.Image = global::WannaCry_FirewallManager.Properties.Resources.SECURITY;
			this.PATCHED_IMAGE.Location = new System.Drawing.Point(12, 213);
			this.PATCHED_IMAGE.Name = "PATCHED_IMAGE";
			this.PATCHED_IMAGE.Size = new System.Drawing.Size(25, 25);
			this.PATCHED_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PATCHED_IMAGE.TabIndex = 6;
			this.PATCHED_IMAGE.TabStop = false;
			// 
			// LOGO
			// 
			this.LOGO.BackColor = System.Drawing.Color.Transparent;
			this.LOGO.Image = global::WannaCry_FirewallManager.Properties.Resources.APP_ICON;
			this.LOGO.Location = new System.Drawing.Point(130, 75);
			this.LOGO.Name = "LOGO";
			this.LOGO.Size = new System.Drawing.Size(100, 100);
			this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LOGO.TabIndex = 7;
			this.LOGO.TabStop = false;
			// 
			// MINIMIZE_BUTTON
			// 
			this.MINIMIZE_BUTTON.AnimationLerpP = 0.8F;
			this.MINIMIZE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.MINIMIZE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MINIMIZE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.DimGray;
			this.MINIMIZE_BUTTON.Image = global::WannaCry_FirewallManager.Properties.Resources.MINIMIZE_BUTTON;
			this.MINIMIZE_BUTTON.Location = new System.Drawing.Point(300, 0);
			this.MINIMIZE_BUTTON.Name = "MINIMIZE_BUTTON";
			this.MINIMIZE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.DarkGray;
			this.MINIMIZE_BUTTON.Size = new System.Drawing.Size(30, 30);
			this.MINIMIZE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.MINIMIZE_BUTTON.TabIndex = 7;
			this.MINIMIZE_BUTTON.TabStop = false;
			this.MINIMIZE_BUTTON.Click += new System.EventHandler(this.MINIMIZE_BUTTON_Click);
			// 
			// APP_TITLE
			// 
			this.APP_TITLE.AutoSize = true;
			this.APP_TITLE.Cursor = System.Windows.Forms.Cursors.Hand;
			this.APP_TITLE.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_TITLE.Location = new System.Drawing.Point(8, 9);
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size(157, 13);
			this.APP_TITLE.TabIndex = 1;
			this.APP_TITLE.Text = "WannaCry 랜섬웨어 보안패치";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.AnimationLerpP = 0.8F;
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.IndianRed;
			this.CLOSE_BUTTON.Image = global::WannaCry_FirewallManager.Properties.Resources.CLOSE_BUTTON;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(330, 0);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.LightCoral;
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(30, 30);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.CLOSE_BUTTON.TabIndex = 0;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// EXECUTE_PORT_BLOCK_BUTTON
			// 
			this.EXECUTE_PORT_BLOCK_BUTTON.AnimationLerpP = 0.8F;
			this.EXECUTE_PORT_BLOCK_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.EXECUTE_PORT_BLOCK_BUTTON.ButtonText = "보안 패치 적용";
			this.EXECUTE_PORT_BLOCK_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.EXECUTE_PORT_BLOCK_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EXECUTE_PORT_BLOCK_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.EXECUTE_PORT_BLOCK_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EXECUTE_PORT_BLOCK_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.EXECUTE_PORT_BLOCK_BUTTON.Location = new System.Drawing.Point(12, 198);
			this.EXECUTE_PORT_BLOCK_BUTTON.Name = "EXECUTE_PORT_BLOCK_BUTTON";
			this.EXECUTE_PORT_BLOCK_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.EXECUTE_PORT_BLOCK_BUTTON.Size = new System.Drawing.Size(200, 40);
			this.EXECUTE_PORT_BLOCK_BUTTON.TabIndex = 3;
			this.EXECUTE_PORT_BLOCK_BUTTON.Text = "보안 패치 적용";
			this.EXECUTE_PORT_BLOCK_BUTTON.UseVisualStyleBackColor = false;
			this.EXECUTE_PORT_BLOCK_BUTTON.Click += new System.EventHandler(this.EXECUTE_PORT_BLOCK_BUTTON_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(360, 250);
			this.Controls.Add(this.LOGO);
			this.Controls.Add(this.PATCHED_IMAGE);
			this.Controls.Add(this.PATCHED_LABEL);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.EXECUTE_PORT_BLOCK_BUTTON);
			this.Controls.Add(this.authorLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WannaCry 랜섬웨어 보안패치";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PATCHED_IMAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MINIMIZE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label authorLabel;
		private FlatButton EXECUTE_PORT_BLOCK_BUTTON;
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private FlatImageButton CLOSE_BUTTON;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.Label PATCHED_LABEL;
		private System.Windows.Forms.PictureBox PATCHED_IMAGE;
		private FlatImageButton MINIMIZE_BUTTON;
		private System.Windows.Forms.PictureBox LOGO;
	}
}

