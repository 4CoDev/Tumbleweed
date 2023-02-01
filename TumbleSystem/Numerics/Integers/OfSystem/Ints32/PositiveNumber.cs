using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Integers.OfSystem.Ints32;

public sealed class PositiveNumber : IScalar<int>
{
	public PositiveNumber(IScalar<int> integer)
	{
		this.integer = integer;
	}

	public int Value()
	{
		if (integer.Value() >= 0) return integer.Value();
		throw new InvalidOperationException("Value is negative.");
	}
	
	private readonly IScalar<int> integer;
}