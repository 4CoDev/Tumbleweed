using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Linears.OfSystem;

public sealed class SizeOfArray<T> : ScalarEnvelope<int>
{
	public SizeOfArray(IScalar<T[]> array) : base
	(
		new ScalarOfDelegate<int>(
			() => array.Value().Length)
	)
	{
	}
}