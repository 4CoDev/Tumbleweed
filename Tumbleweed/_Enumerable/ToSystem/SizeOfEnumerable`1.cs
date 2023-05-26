using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.ToSystem;

public sealed class SizeOfEnumerable<T> : ScalarEnvelope<Int32>
{
	public SizeOfEnumerable(IEnumerable<T> enumerable) : base
	(
		new ResultOfFunction<Int32>(enumerable.Count)
	)
	{
	}
}