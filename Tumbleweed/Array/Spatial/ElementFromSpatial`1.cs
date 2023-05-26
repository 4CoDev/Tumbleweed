using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromArray;

namespace Tumbleweed.Array.Spatial;

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