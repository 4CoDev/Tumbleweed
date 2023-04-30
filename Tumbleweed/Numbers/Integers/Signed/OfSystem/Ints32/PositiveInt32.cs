using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.OfSystem.Ints32;

public sealed class PositiveInt32 : IScalar<Int32>
{
	public PositiveInt32(IScalar<Int32> integer)
	{
		this.integer = integer;
	}

	public Int32 Value
	{
		get
		{
			if (integer.Value >= 0) return integer.Value;
			throw new InvalidOperationException("Value is negative.");
		}
	}

	private readonly IScalar<Int32> integer;
}