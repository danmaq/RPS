namespace RPS
{
	// 対戦相手
	class Player
	{
		// 名前
		public string name = "Anonymous";
	
		// 思考パターン
		public IAI ai = AIEnemy.instance;

		// 手
		public RPS pattern;

		// 考える
		public void think()
		{
			ai.think(this);
		}
	}
}
