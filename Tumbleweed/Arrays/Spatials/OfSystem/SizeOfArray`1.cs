using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Spatials.OfSystem;

public sealed class SizeOfArray<T> : EnumerableEnvelope<int>
{
	public SizeOfArray(IScalar<T[,,]> array) : base
	(
		new EnumerableOfDelegates<int>(
			() => array.Value.GetLength(0),
			() => array.Value.GetLength(1),
			() => array.Value.GetLength(2))
	)
	{
	}
}