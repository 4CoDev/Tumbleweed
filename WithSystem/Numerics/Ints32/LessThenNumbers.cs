using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.WithSystem.Numerics.Ints32;

public sealed class LessThenNumbers : EnumerableEnvelope<IScalar<int>>
{
	public LessThenNumbers
	(
		IEnumerable<IScalar<int>> values,
		IScalar<int> max
	) : base
	(
		new EnumerableOfScalar<IScalar<int>>(
			new Scalar.LessThenNumbers(values, max))
	)
	{
	}
}