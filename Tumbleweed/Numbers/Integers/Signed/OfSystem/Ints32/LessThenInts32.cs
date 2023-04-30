using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.OfSystem.Ints32;

public sealed class LessThenInts32 : EnumerableEnvelope<IScalar<Int32>>
{
	public LessThenInts32
	(
		IEnumerable<IScalar<Int32>> values,
		IScalar<Int32> max
	) : base
	(
		new EnumerableOfScalar<IScalar<Int32>>(
			new Scalar.LessThenInts32(values, max))
	)
	{
	}
}