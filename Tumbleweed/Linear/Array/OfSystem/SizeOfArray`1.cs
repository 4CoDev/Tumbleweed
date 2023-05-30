using Tumbleweed.Scalar;

namespace Tumbleweed.Linear.Array.OfSystem;

public sealed class SizeOfArray<T> : ScalarEnvelope<Int32>
{
	public SizeOfArray(IScalar<T[]> array) : base
	(
		new ResultOfFunction<Int32>(
			() => array.Value.Length)
	)
	{
	}
}