namespace RPS
{
	// 手のAAを作るだけ
	static class Hand
	{
		// AA
		static string[] aa = new string[(int)RPS.__reserved];

		// コンストラクタ
		static Hand()
		{
			aa[(int)RPS.rock] = " ___\n|___ﾌ";
			aa[(int)RPS.paper] = "||||\n|___/";
			aa[(int)RPS.scissor] = " _||\n|___ﾌ";
		}

		// AA取得
		public static string getAA(RPS rps)
		{
			return aa[(int)rps];
		}
	}
}
