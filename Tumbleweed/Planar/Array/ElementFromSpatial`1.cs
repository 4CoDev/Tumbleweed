using Tumbleweed.Array;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Planar.Point;
using Tumbleweed.Planar.Point.Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromArray;

namespace Tumbleweed.Planar.Array;

public sealed class ElementFromPlanar<T> : ScalarEnvelope<T>
{
	public ElementFromPlanar
	(
		IArray<T> array,
		IPoint<INatural> indices
	) : base
	(
		new ScalarWithIndices<T>(
			array,
			new EnumerableFromPlanar<INatural>(indices))
	)
	{
	}
}