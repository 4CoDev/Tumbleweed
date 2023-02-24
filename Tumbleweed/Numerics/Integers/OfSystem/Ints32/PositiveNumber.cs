using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.OfSystem.Ints32;

public sealed class PositiveNumber : IScalar<int>
{
	public PositiveNumber(IScalar<int> integer)
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