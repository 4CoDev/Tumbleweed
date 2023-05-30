using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Planar.Array.OfSystem;

public sealed class SizeOfArray<T> : EnumerableEnvelope<Int32>
{
	public SizeOfArray(IScalar<T[,]> array) : base
	(
		new EnumerableOfFunctions<Int32>(
			() => array.Value.GetLength(0),
			() => array.Value.GetLength(1))
	)
	{
	}
}