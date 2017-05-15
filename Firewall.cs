using System;
using System.Diagnostics;

namespace WannaCry_FirewallManager
{
	// https://technet.microsoft.com/ko-kr/library/security/ms17-010.aspx
	
	static class Firewall
	{
		private static string ExecuteCMD( string command )
		{
			ProcessStartInfo proInfo = new ProcessStartInfo( )
			{
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardInput = true,
				RedirectStandardError = true,
				CreateNoWindow = true,
				FileName = Environment.GetFolderPath( Environment.SpecialFolder.System ) + @"\cmd.exe",
				Verb = "runas"
			};

			Process pro = new Process( )
			{
				StartInfo = proInfo
			};
			pro.Start( );

			// CMD 에 보낼 명령어를 입력 합니다.
			pro.StandardInput.WriteLine( command );
			pro.StandardInput.Close( );

			// 결과 값을 리턴 받습니다.
			string resultValue = pro.StandardOutput.ReadToEnd( );


			pro.WaitForExit( );
			pro.Close( );

			resultValue = resultValue.Substring( resultValue.IndexOf( command ) + command.Length + 2 );
			//MessageBox.Show( resultValue );

			return resultValue;
		}

		public static bool IsPatched( )
		{
			//MessageBox.Show( );
			return !ExecuteCMD( "netsh advfirewall firewall show rule name=\"WannaCry 랜섬웨어 차단\"" ).Contains( "지정된 조건과 일치하는 규칙이 없습니다." );
			//return .Substring( 0, 1 ) == "1";
		}

		public static bool SetStatus( bool status )
		{
			return ExecuteCMD( "netsh advfirewall set AllProfiles state on | find /c \"확인됨\"" ).Substring( 0, 1 ) == "1";
		}

		public static bool GetStatus( )
		{
			return ExecuteCMD( "netsh advfirewall show AllProfiles state | find /c \"사용 안 함\"" ).Substring( 0, 1 ) == "0";
		}

		public static bool ApplyPatch( )
		{
			return ExecuteCMD( "netsh advfirewall firewall add rule name=\"WannaCry 랜섬웨어 차단\" desc=\"WannaCry 랜섬웨어 차단 스크립트 by L7D\" profile=any dir=in action=block protocol=tcp localport=139,445 | find /c \"확인됨\"" ).Substring( 0, 1 ) == "1";

			//MessageBox.Show( resultValue );
		}
	}
}
