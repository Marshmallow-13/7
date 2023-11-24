namespace Lib7
{
	public class Pair
	{
		private int _one;
		private int _second;

		public virtual int One
		{
			get
			{
				return _one;
			}
			set
			{
				_one = value;
			}
		} // ��������
		public virtual int Second
		{
			get
			{
				return _second;
			}
			set
			{
				_second = value;
			}
		} // ��������


		public Pair(int one, int second)
		{
			_one = one;
			_second = second;
		} // ����������� 

		/// <summary>
		/// �������� ����� ���� ����� (������� ����� ���� � ������)
		/// </summary>
		/// <returns>��������� ����� ����� ���� �����</returns>
		public int Sum()
		{
			return _one + _second;
		}
		/// <summary>
		/// �������� ���� ���� ����� � ������ ����� �����
		/// </summary>
		/// <param name="second">������ ���� �����</param>
		/// <returns>������ ���� ����� (���������� ����� ������ � ������)</returns>
		public Pair Sum(Pair second)
		{
			return new Pair(One + second.One, Second + second.Second);
		}

		/// <summary>
		/// ����������  ���� ����� �� 1
		/// </summary>
		/// <param name="pair"></param>
		/// <returns>���� ����� � ������ �� ������� ������</returns>
		public static Pair operator --(Pair pair)
		{
			pair.One--;
			pair.Second--;

			return pair;
		}

		/// <summary>
		/// ���������� ���� ����� �� 1
		/// </summary>
		/// <param name="pair"></param>
		/// <returns></returns>
		public static Pair operator ++(Pair pair)
		{
			pair.One++;
			pair.Second++;
			return pair;
		}
	}
}

