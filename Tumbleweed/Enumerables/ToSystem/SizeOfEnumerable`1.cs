using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.ToSystem;

public sealed class SizeOfEnumerable<T> : ScalarEnvelope<Int32>
{
	public SizeOfEnumerable(IEnumerable<T> enumerable) : base
	(
		new ValueOfFunction<Int32>(enumerable.Count)
	)
	{
	}
}