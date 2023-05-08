using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Linears.OfSystem;

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