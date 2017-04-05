using System;

namespace RPS
{
	// プレイヤーの思考パターン
	class AIPlayer : IAI
	{
		// オブジェクト
		public static readonly IAI instance = new AIPlayer();

		// パターン一覧
		RPS[] rps = { RPS.rock, RPS.scissor, RPS.paper };

		// コンストラクタ
		private AIPlayer()
		{
		}

		// 考える
		public void think(Player player)
		{
			Console.WriteLine("右から選ぶ: 1.グー, 2.チョキ, 3.パー 0.終了");
			bool commied = false;
			do
			{
				char c = Console.ReadKey().KeyChar;
				switch (c)
				{
					case '0':
						Environment.Exit(0);
						break;
					case '1':
					case '2':
					case '3':
						commied = true;
						player.pattern = rps[(int)char.GetNumericValue(c) - 1];
						break;
					default:
						Console.WriteLine("そのキーは使えない");
						break;
				}
			}
			while (!commied);
		}
	}
}
