using Tumbleweed.Arrays;
using Tumbleweed.Numbers.Integers.Natural;

namespace Tumbleweed.Scalars.FromArray;

public sealed class ScalarWithIndices<T> : ScalarEnvelope<T>
{
	public ScalarWithIndices
	(
		IArray<T> array,
		IEnumerable<INatural> indices
	) : base
	(
		new ValueOfFunction<T>(
			() => array[indices])
	)
	{
	}
}