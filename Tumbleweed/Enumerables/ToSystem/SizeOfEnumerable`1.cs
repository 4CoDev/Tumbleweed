using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.ToSystem;

public sealed class SizeOfEnumerable<T> : ScalarEnvelope<int>
{
	public SizeOfEnumerable(IEnumerable<T> enumerable) : base
	(
		new ScalarOfDelegate<int>(enumerable.Count)
	)
	{
	}
}