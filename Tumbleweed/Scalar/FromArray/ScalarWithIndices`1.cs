using Tumbleweed.Array;
using Tumbleweed.Number.Integer.Natural;

namespace Tumbleweed.Scalar.FromArray;

public sealed class ScalarWithIndices<T> : ScalarEnvelope<T>
{
	public ScalarWithIndices
	(
		IArray<T> array,
		IEnumerable<INatural> indices
	) : base
	(
		new ResultOfFunction<T>(
			() => array[indices])
	)
	{
	}
}