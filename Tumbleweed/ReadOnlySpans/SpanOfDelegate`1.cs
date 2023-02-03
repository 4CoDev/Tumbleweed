namespace Tumbleweed.ReadOnlySpans;

public sealed class SpanOfDelegate<T> : IReadOnlySpan<T>
{
	public SpanOfDelegate(SpanDelegate<T> @delegate)
	{
		this.@delegate = @delegate;
	}

	public ReadOnlySpan<T> Value
	{
		get => @delegate();
	}
	
	private readonly SpanDelegate<T> @delegate;
}