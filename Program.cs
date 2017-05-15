using System;
using System.Threading;
using System.Windows.Forms;

namespace WannaCry_FirewallManager
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		private static Mutex mutex = new Mutex( true, "{c3c76933-a360-4259-b5cb-34df1d1ec77a}" );

		[STAThread]
		static void Main( )
		{
			if ( mutex.WaitOne( TimeSpan.Zero, true ) )
			{
				Application.EnableVisualStyles( );
				Application.SetCompatibleTextRenderingDefault( false );
				Application.Run( new MainForm( ) );
				mutex.ReleaseMutex( );
			}
			else
			{
				MessageBox.Show( "프로그램이 이미 실행 중 입니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}
	}
}
