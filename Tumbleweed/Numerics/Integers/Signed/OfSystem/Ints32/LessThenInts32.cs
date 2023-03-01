using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.OfSystem.Ints32;

public sealed class LessThenInts32 : EnumerableEnvelope<IScalar<int>>
{
	public LessThenInts32
	(
		IEnumerable<IScalar<int>> values,
		IScalar<int> max
	) : base
	(
		new EnumerableOfScalar<IScalar<int>>(
			new Scalar.LessThenInts32(values, max))
	)
	{
	}
}