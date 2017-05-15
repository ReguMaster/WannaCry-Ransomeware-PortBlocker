using System;
using System.Drawing;
using System.Windows.Forms;

namespace WannaCry_FirewallManager
{
	public partial class MainForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( Color.Silver )
		{
			Width = 1
		};

		public MainForm( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true );
			this.UpdateStyles( );
			this.Opacity = 0;
		}

		private void MainForm_Load( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );

			this.EXECUTE_PORT_BLOCK_BUTTON.Visible = false;
			this.PATCHED_LABEL.Visible = false;
			this.PATCHED_IMAGE.Visible = false;

			if ( Firewall.IsPatched( ) )
			{
				this.EXECUTE_PORT_BLOCK_BUTTON.Visible = false;
				this.PATCHED_LABEL.Visible = true;
				this.PATCHED_IMAGE.Visible = true;
			}
			else
			{
				this.EXECUTE_PORT_BLOCK_BUTTON.Visible = true;
				this.PATCHED_LABEL.Visible = false;
				this.PATCHED_IMAGE.Visible = false;
			}
		}

		private void EXECUTE_PORT_BLOCK_BUTTON_Click( object sender, EventArgs e )
		{
			if ( MessageBox.Show( this, "보안 패치를 하시겠습니까?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No ) return;
			if ( Firewall.IsPatched( ) )
			{
				MessageBox.Show( this, "보안 패치가 이미 설치되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information );
				return;
			}

			this.EXECUTE_PORT_BLOCK_BUTTON.Enabled = false;
			this.EXECUTE_PORT_BLOCK_BUTTON.ButtonText = "보안 패치 중 ...";

			bool firewallStartSuccess = false;
			bool firewallPortPatchSuccess = false;

			if ( !Firewall.GetStatus( ) )
				firewallStartSuccess = Firewall.SetStatus( true );

			if ( !Firewall.IsPatched( ) )
				firewallPortPatchSuccess = Firewall.ApplyPatch( );


			//try
			//{
			//	if ( !Firewall.GetStatus( ) )
			//	{
			//		if ( MessageBox.Show( this, "Windows 방화벽이 꺼져 있습니다, 켜시겠습니까?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
			//		{
			//			if ( Firewall.SetStatus( true ) )
			//			{
			//				if ( Firewall.ApplyPatch( ) )
			//				{
			//					MessageBox.Show( this, "보안 패치를 완료했습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information );
			//				}
			//				else
			//				{
			//					MessageBox.Show( this, "보안 패치를 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			//				}
			//			}
			//			else
			//			{
			//				MessageBox.Show( this, "Windows 방화벽을 켤 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			//			}
			//		}
			//		else
			//		{
			//			MessageBox.Show( this, "Windows 방화벽이 꺼져있으면 보안 패치를 할 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			//		}
			//	}
			//	else
			//	{
			//		if ( Firewall.ApplyPatch( ) )
			//		{
			//			MessageBox.Show( this, "보안 패치를 완료했습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information );
			//		}
			//		else
			//		{
			//			MessageBox.Show( this, "보안 패치를 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			//		}
			//	}
			//}
			//finally
			//{
			//	this.EXECUTE_PORT_BLOCK_BUTTON.Enabled = true;
			//	this.EXECUTE_PORT_BLOCK_BUTTON.ButtonText = "보안 패치 적용";

			//	if ( Firewall.IsPatched( ) )
			//	{
			//		this.EXECUTE_PORT_BLOCK_BUTTON.Visible = false;
			//		this.PATCHED_LABEL.Visible = true;
			//		this.PATCHED_IMAGE.Visible = true;
			//	}
			//	else
			//	{
			//		this.EXECUTE_PORT_BLOCK_BUTTON.Visible = true;
			//		this.PATCHED_LABEL.Visible = false;
			//		this.PATCHED_IMAGE.Visible = false;
			//	}
			//}
		}

		private void authorLabel_Click( object sender, EventArgs e )
		{
			try
			{
				System.Diagnostics.Process.Start( "http://cafe.naver.com/CafeMemberNetworkView.nhn?m=view&clubid=25430492&memberid=smhjyh2007" );
			}
			catch
			{

			}
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void APP_TITLE_BAR_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				this.Location = new Point(
					this.Left - ( startPoint.X - e.X ),
					Math.Max( this.Top - ( startPoint.Y - e.Y ), Screen.FromHandle( this.Handle ).WorkingArea.Top )
				);
			}
		}

		private void APP_TITLE_BAR_MouseDown( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
				startPoint = e.Location;
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			Animation.UI.FadeOutShutdown( this );
		}

		private void MainForm_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void MINIMIZE_BUTTON_Click( object sender, EventArgs e )
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
