using Tumbleweed.Array;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Enumerable;
using INaturalNumber = Tumbleweed.Number.Integer.Natural.INatural;

namespace Tumbleweed.Scalar.FromArray.FromSpatial;

public sealed class ScalarWithIndex<T> : ScalarEnvelope<T>
{
	public ScalarWithIndex
	(
		IArray<T> array,
		IPoint<INaturalNumber> index
	) : base
	(
		new ScalarWithIndices<T>(
			array,
			new EnumerableFromSpatial<INaturalNumber>(index))
	)
	{
	}
}