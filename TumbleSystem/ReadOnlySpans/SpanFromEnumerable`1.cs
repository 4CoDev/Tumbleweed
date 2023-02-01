using TumbleSystem.Arrays.ToSystem;

namespace TumbleSystem.ReadOnlySpans;

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