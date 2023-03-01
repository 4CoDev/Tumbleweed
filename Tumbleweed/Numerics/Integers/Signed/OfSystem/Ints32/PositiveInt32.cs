using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32;

public sealed class PositiveInt32 : IScalar<int>
{
	public PositiveInt32(IScalar<int> integer)
	{
		this.integer = integer;
	}

	public int Value
	{
		get
		{
			if (integer.Value >= 0) return integer.Value;
			throw new InvalidOperationException("Value is negative.");
		}
	}

	private readonly IScalar<int> integer;
}