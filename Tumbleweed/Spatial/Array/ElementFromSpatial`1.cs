using Tumbleweed.Array;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromArray;
using Tumbleweed.Spatial.Point;
using Tumbleweed.Spatial.Point.Enumerable;

namespace Tumbleweed.Spatial.Array;

public sealed class ElementFromSpatial<T> : ScalarEnvelope<T>
{
	public ElementFromSpatial
	(
		IArray<T> array,
		IPoint<INatural> indices
	) : base
	(
		new ScalarWithIndices<T>(
			array,
			new EnumerableFromSpatial<INatural>(indices))
	)
	{
	}
}