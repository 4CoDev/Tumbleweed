using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Points.Planar;
using Tumbleweed.Points.Planar.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromArray;

namespace Tumbleweed.Arrays.Planars;

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