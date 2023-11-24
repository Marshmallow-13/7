namespace Lib7
{
	public class Money : Pair
	{
		private int _roubles;
		private int _pennies;

		public override int One
		{
			get { return _roubles; }
			set { _roubles = value; }
		}
		public override int Second
		{
			get { return _pennies; }
			set
			{
				_pennies = value;
				_roubles += _pennies % 100;
				_pennies %= 100;
			}
		}

		public int Roubles
		{
			get { return One; }
			set { One = value; }
		}
		public int Pennies
		{
			get { return Second; }
			set { Second = value; }
		}
		/* 
		 * Использовать класс  Pair  (пара  чисел). 
		 * Определить  класс-наследник Money с характеристиками: рубли и копейки. 
		 * Переопределить операцию сложения и определить методы вычитания и деления денежных сумм.
		 */
		public Money(int roubles, int pennies) : base(roubles, pennies)
		{
			_roubles = roubles + pennies / 100;
			_pennies = pennies % 100;
		}

		public static Money operator +(Money a, Money b)
		{
			return new Money(a.One + b.One, a.Second + b.Second);
		}

		public Money Difference(Money other)
		{
			return new Money(One - other.One, Second - other.Second);
		}

		public Money Division(int number)
		{
			return new Money(0, (One * 100 + Second) / number);
		}
	}
}
