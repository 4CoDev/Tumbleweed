using Tumbleweed.Scalars;

namespace Tumbleweed.WithSystem.Numerics.Ints32;

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