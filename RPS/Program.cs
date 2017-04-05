using System;

namespace RPS
{
	// メインプログラム
	class Program
	{
		// 人数
		const int PLAYER_COUNT = 5;

		// 相手一覧
		Player[] players = new Player[PLAYER_COUNT];

		// ターン数
		int turn;

		// ここから始め
		static void Main(string[] args)
		{
			// タイトルを表示
			Console.WriteLine("じゃんけん");
			new Program().run();
		}

		// コンストラクタでゲームの場を作る
		Program()
		{
			// 対戦相手を作る
			for (int i = PLAYER_COUNT; --i >= 0; )
			{
				Player player = new Player();
				player.name = string.Format("敵番号 {0}", i);
				players[i] = player;
			}
			// 零番が俺だ
			players[0].name = "あなた";
			players[0].ai = AIPlayer.instance;
		}

		// メインループ
		void run()
		{
			while (true)
			{
				// ターン表示→考える→手を表示→判定の繰り返し
				Console.WriteLine("==================");
				Console.WriteLine("ターン {0}", turn++);
				think();
				int[] result = open();
				judge(result[(int)RPS.rock], result[(int)RPS.paper], result[(int)RPS.scissor]);
			}
		}

		// 考える
		private void think()
		{
			for (int i = players.Length; --i >= 0; )
			{
				players[i].think();
			}
		}

		// 全員の手を表示
		private int[] open()
		{
			int[] result = new int[(int)RPS.__reserved];
			for (int i = players.Length; --i >= 0; )
			{
				RPS pattern = players[i].pattern;
				Console.WriteLine("\n{0} の出した手:", players[i].name);
				Console.WriteLine(Hand.getAA(pattern));
				result[(int)pattern]++;
			}
			return result;
		}

		// 勝敗判定
		private void judge(int rock, int paper, int scissor)
		{
			Console.WriteLine(" - - - - - - - ");
			RPS won = Judge.judge(rock, paper, scissor);
			if (won == RPS.__reserved)
			{
				Console.WriteLine("あいこで！");
			}
			else
			{
				Console.WriteLine(Hand.getAA(won));
				Console.WriteLine("が勝ちました");
			}
		}
	}
}
