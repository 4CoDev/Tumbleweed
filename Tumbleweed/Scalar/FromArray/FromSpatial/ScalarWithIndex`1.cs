using Tumbleweed.Array;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Enumerable;
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