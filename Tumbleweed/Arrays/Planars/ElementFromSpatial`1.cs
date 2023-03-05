using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Planar.ToEnumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Planars;

public sealed class ElementFromPlanar<T> : ScalarEnvelope<T>
{
	public ElementFromPlanar
	(
		IArray<T> array,
		IPlanar<INaturalInteger> indices
	) : base
	(
		new ElementFromArray<T>(
			array,
			new EnumerableFromPlanar<INaturalInteger>(indices))
	)
	{
	}
}