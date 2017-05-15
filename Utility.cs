using System;
using System.Drawing;
using System.Windows.Forms;

namespace WannaCry_FirewallManager
{
	static class Utility
	{
		// http://stackoverflow.com/questions/3519539/how-to-check-if-a-string-contains-any-of-some-strings
		public static bool ContainsMultiple( this string target, params string[ ] args )
		{
			foreach ( string i in args )
			{
				if ( target.Contains( i ) )
					return true;
			}

			return false;
		}

		// Lerp (Linear interpolation, 선형보간법) 
		// p 의 값이 0에 가까워질수록 ( a - b ) 에 비례하여 중간 값이 커진다 (애니메이션이 빨라진다)
		// p 의 값이 1에 가까워질수록 ( a - b ) 에 비례하여 중간 값이 작아진다 (애니메이션이 느려진다)
		// ( p 의 값이 0 ~ 1F )
		// http://stackoverflow.com/questions/33044848/c-sharp-lerping-from-position-to-position
		// http://dodnet.tistory.com/993
		public static float Lerp( float a, float b, float p )
		{
			return a * p + b * ( 1 - p );
		}

		public static int Clamp( int original, int max, int min )
		{
			if ( original > max )
				return max;

			if ( original < min )
				return min;

			return original;
		}

		public static Color LerpColor( Color a, Color b, float p )
		{
			float newR = 0, newG = 0, newB = 0, newA = 0;

			newR = a.R * p + b.R * ( 1 - p );
			newG = a.G * p + b.G * ( 1 - p );
			newB = a.B * p + b.B * ( 1 - p );
			newA = a.A * p + b.A * ( 1 - p );

			return Color.FromArgb( ( int ) Math.Round( newA ), ( int ) Math.Round( newR ), ( int ) Math.Round( newG ), ( int ) Math.Round( newB ) );
		}

		// http://bananamandoo.tistory.com/27
		public static void Delay( int ms )
		{
			DateTime thisMoment = DateTime.Now;
			DateTime afterWards = thisMoment.Add( new TimeSpan( 0, 0, 0, 0, ms ) );

			while ( afterWards >= thisMoment )
			{
				Application.DoEvents( );
				thisMoment = DateTime.Now;
			}
		}
	}
}