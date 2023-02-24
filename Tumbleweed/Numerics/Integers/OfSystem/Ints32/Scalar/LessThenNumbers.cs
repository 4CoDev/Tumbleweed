using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.OfSystem.Ints32.Scalar;

public sealed class LessThenNumbers : IScalar<IEnumerable<IScalar<int>>>
{
	public LessThenNumbers
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