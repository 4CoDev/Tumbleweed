using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Integers.OfSystem.Ints32;

public sealed class LessThenNumber : IScalar<int>
{
	public LessThenNumber(IScalar<int> value, IScalar<int> max)
	{
		this.value = value;
		this.max = max;
	}

	public int Value()
	{
		if (value.Value() < max.Value()) return value.Value();
		throw new InvalidOperationException("Value is greater then max");
	}
	
	private readonly IScalar<int> value;
	
	private readonly IScalar<int> max;
}