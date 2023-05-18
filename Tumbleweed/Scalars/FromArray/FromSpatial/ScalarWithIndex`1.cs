using Tumbleweed.Arrays;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Points.Spatial.Enumerables;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;

namespace Tumbleweed.Scalars.FromArray.FromSpatial;

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