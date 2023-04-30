using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.OfSystem.Ints32.Scalar;

public sealed class LessThenInts32 : IScalar<IEnumerable<IScalar<Int32>>>
{
	public LessThenInts32
	(
		IEnumerable<IScalar<Int32>> values,
		IScalar<Int32> max
	)
	{
		this.values = values;
		this.max = max;
	}

	public IEnumerable<IScalar<Int32>> Value
	{
		get
		{
			if (values.Any(value => value.Value > max.Value))
			{
				throw new InvalidOperationException("Value is greater then max");
			}
			return values;
		}
	}

	private readonly IEnumerable<IScalar<Int32>> values;
	
	private readonly IScalar<Int32> max;
}