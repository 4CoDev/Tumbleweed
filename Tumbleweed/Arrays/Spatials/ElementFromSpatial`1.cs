using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.ToEnumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Spatials;

public sealed class ElementFromSpatial<T> : ScalarEnvelope<T>
{
	public ElementFromSpatial
	(
		IArray<T> array,
		ISpatial<INatural> indices
	) : base
	(
		new ElementFromArray<T>(
			array,
			new EnumerableFromSpatial<INatural>(indices))
	)
	{
	}
}