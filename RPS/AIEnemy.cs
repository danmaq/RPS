using System;

namespace RPS
{
	// 敵の思考パターン
	class AIEnemy : IAI
	{
		// オブジェクト
		public static readonly IAI instance = new AIEnemy();

		// パターン一覧
		RPS[] rps = { RPS.rock, RPS.paper, RPS.scissor };

		// 乱数
		Random rnd = new Random();

		// コンストラクタ
		private AIEnemy()
		{
		}

		// 考える
		public void think(Player player)
		{
			player.pattern = rps[rnd.Next(rps.Length)];
		}
	}
}
