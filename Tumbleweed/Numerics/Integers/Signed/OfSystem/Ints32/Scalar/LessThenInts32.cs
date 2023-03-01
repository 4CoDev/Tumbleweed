using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32.Scalar;

public sealed class LessThenInts32 : IScalar<IEnumerable<IScalar<int>>>
{
	public LessThenInts32
	(
		IEnumerable<IScalar<int>> values,
		IScalar<int> max
	)
	{
		this.values = values;
		this.max = max;
	}

	public IEnumerable<IScalar<int>> Value
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

	private readonly IEnumerable<IScalar<int>> values;
	
	private readonly IScalar<int> max;
}