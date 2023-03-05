using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Spatials.OfSystem;

public sealed class SizeOfArray<T> : EnumerableEnvelope<Int32>
{
	public SizeOfArray(IScalar<T[,,]> array) : base
	(
		new EnumerableOfDelegates<Int32>(
			() => array.Value.GetLength(0),
			() => array.Value.GetLength(1),
			() => array.Value.GetLength(2))
	)
	{
	}
}