using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32;

public sealed class LessThenInt32 : IScalar<int>
{
	public LessThenInt32(IScalar<int> value, IScalar<int> max)
	{
		this.value = value;
		this.max = max;
	}

	public int Value
	{
		get
		{
			if (value.Value < max.Value) return value.Value;
			throw new InvalidOperationException("Value is greater then max");
		}
	}

	private readonly IScalar<int> value;
	
	private readonly IScalar<int> max;
}