using Tumbleweed.Arrays.Linears.ToSystem;

namespace Tumbleweed.ReadOnlySpans;

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