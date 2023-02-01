namespace TumbleSystem.ReadOnlySpans;

public abstract class SpanEnvelope<T> : IReadOnlySpan<T>
{
	protected SpanEnvelope(SpanDelegate<T> @delegate) : this
	(
		new SpanOfDelegate<T>(@delegate)
	)
	{
	}
	
	protected SpanEnvelope(IReadOnlySpan<T> span)
	{
		this.span = span;
	}
	
	public ReadOnlySpan<T> Value
	{
		get => span.Value;
	}
	
	private readonly IReadOnlySpan<T> span;
}