using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Array.Spatial.OfSystem;

public sealed class SizeOfArray<T> : EnumerableEnvelope<Int32>
{
	public SizeOfArray(IScalar<T[,,]> array) : base
	(
		new EnumerableOfFunctions<Int32>(
			() => array.Value.GetLength(0),
			() => array.Value.GetLength(1),
			() => array.Value.GetLength(2))
	)
	{
	}
}