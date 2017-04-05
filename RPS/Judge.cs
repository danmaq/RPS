namespace RPS
{
	// 判定
	static class Judge
	{

		// 複数の手で判定
		static public RPS judge(int rock, int paper, int scissor)
		{
			RPS result = RPS.__reserved;
			// グーチョキパーが全部出ていたら強制あいこ
			if (!(rock > 0 && paper > 0 && scissor > 0))
			{
				RPS expr1 = RPS.__reserved;
				RPS expr2 = RPS.__reserved;
				// グーとパーで判定
				if (rock > 0 && paper > 0)
				{
					expr1 = RPS.rock;
					expr2 = RPS.paper;
				}
				// パーとチョキで判定
				if (paper > 0 && scissor > 0)
				{
					expr1 = RPS.paper;
					expr2 = RPS.scissor;
				}
				// チョキとグーで判定
				if (scissor > 0 && rock > 0)
				{
					expr1 = RPS.scissor;
					expr2 = RPS.rock;
				}
				result = judge(expr1, expr2);
			}
			return result;
		}

		// 一対一で判定
		static public RPS judge(RPS expr1, RPS expr2)
		{
			// 下の判定に引っかからなければあいこ
			RPS result = RPS.__reserved;
			// グー対パーはパーの勝ち
			if ((expr1 == RPS.rock && expr2 == RPS.paper) ||
				(expr2 == RPS.rock && expr1 == RPS.paper))
			{
				result = RPS.paper;
			}
			// パー対チョキはチョキの勝ち
			if ((expr1 == RPS.paper && expr2 == RPS.scissor) ||
				(expr2 == RPS.paper && expr1 == RPS.scissor))
			{
				result = RPS.scissor;
			}
			// チョキ対グーはグーの勝ち
			if ((expr1 == RPS.scissor && expr2 == RPS.rock) ||
				(expr2 == RPS.scissor && expr1 == RPS.rock))
			{
				result = RPS.rock;
			}
			return result;
		}
	}
}
