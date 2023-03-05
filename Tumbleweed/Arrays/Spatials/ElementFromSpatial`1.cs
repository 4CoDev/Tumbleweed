using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Numerics.Spatial.ToEnumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Spatials;

public sealed class ElementFromSpatial<T> : ScalarEnvelope<T>
{
	public ElementFromSpatial
	(
		IArray<T> array,
		ISpatial<INaturalInteger> indices
	) : base
	(
		new ElementFromArray<T>(
			array,
			new EnumerableFromSpatial<INaturalInteger>(indices))
	)
	{
	}
}