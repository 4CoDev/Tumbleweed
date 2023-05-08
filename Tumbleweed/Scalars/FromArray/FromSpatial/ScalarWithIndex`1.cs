using Tumbleweed.Arrays;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Numbers.Spatial.ToEnumerables;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;

namespace Tumbleweed.Scalars.FromArray.FromSpatial;

public sealed class ScalarWithIndex<T> : ScalarEnvelope<T>
{
	public ScalarWithIndex
	(
		IArray<T> array,
		ISpatial<INaturalNumber> index
	) : base
	(
		new ScalarWithIndices<T>(
			array,
			new EnumerableFromSpatial<INaturalNumber>(index))
	)
	{
	}
}