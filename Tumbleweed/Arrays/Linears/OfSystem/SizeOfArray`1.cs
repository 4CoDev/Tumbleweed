using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Linears.OfSystem;

public sealed class SizeOfArray<T> : ScalarEnvelope<Int32>
{
	public SizeOfArray(IScalar<T[]> array) : base
	(
		new ValueOfDelegate<Int32>(
			() => array.Value.Length)
	)
	{
	}
}