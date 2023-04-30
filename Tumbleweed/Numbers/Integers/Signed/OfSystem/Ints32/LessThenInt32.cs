using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.OfSystem.Ints32;

public sealed class LessThenInt32 : IScalar<Int32>
{
	public LessThenInt32(IScalar<Int32> value, IScalar<Int32> max)
	{
		this.value = value;
		this.max = max;
	}

	public Int32 Value
	{
		get
		{
			if (value.Value < max.Value) return value.Value;
			throw new InvalidOperationException("Value is greater then max");
		}
	}

	private readonly IScalar<Int32> value;
	
	private readonly IScalar<Int32> max;
}