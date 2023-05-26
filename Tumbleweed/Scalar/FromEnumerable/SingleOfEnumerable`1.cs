using Tumbleweed._Enumerable.FromSystem;

namespace Tumbleweed.Scalar.FromEnumerable;

public sealed class SingleOfEnumerable<T> : ScalarEnvelope<T>
{
	public SingleOfEnumerable
	(
		IEnumerable<T> enumerable
	) : base
	(
		new FromSystem.ElementAtIndex<T>(
			new EnumerableWithSize<T>(enumerable, 1),
			0)
	)
	{
	}
}