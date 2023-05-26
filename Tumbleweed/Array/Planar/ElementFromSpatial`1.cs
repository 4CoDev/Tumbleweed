using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Point.Planar;
using Tumbleweed.Point.Planar.Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromArray;

namespace Tumbleweed.Array.Planar;

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