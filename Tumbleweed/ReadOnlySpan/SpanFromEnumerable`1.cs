using Tumbleweed.Linear.Array.ToSystem;
using Tumbleweed.ReadOnlySpan.FromSystem;

namespace Tumbleweed.ReadOnlySpan;

public sealed class SpanFromEnumerable<T> : SpanEnvelope<T>
{
	public SpanFromEnumerable(IEnumerable<T> enumerable) : base
	(
		new SpanFromArray<T>(
			new ArrayFromEnumerable<T>(enumerable))
	)
	{
	}
}