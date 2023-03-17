using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays;

public sealed class ElementFromArray<T> : ScalarEnvelope<T>
{
	public ElementFromArray
	(
		IArray<T> array,
		IEnumerable<INaturalInteger> indices
	) : base
	(
		new ValueOfFunction<T>(
			() => array[indices])
	)
	{
	}
}