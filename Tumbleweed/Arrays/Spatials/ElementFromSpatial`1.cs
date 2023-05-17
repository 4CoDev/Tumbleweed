using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.ToEnumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromArray;

namespace Tumbleweed.Arrays.Spatials;

public sealed class ElementFromSpatial<T> : ScalarEnvelope<T>
{
	public ElementFromSpatial
	(
		IArray<T> array,
		ISpatial<INatural> indices
	) : base
	(
		new ScalarWithIndices<T>(
			array,
			new EnumerableFromSpatial<INatural>(indices))
	)
	{
	}
}