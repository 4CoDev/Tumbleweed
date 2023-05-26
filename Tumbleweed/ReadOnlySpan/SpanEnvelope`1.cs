namespace Tumbleweed.ReadOnlySpan;

public abstract class SpanEnvelope<T> : IReadOnlySpan<T>
{
	protected SpanEnvelope(IReadOnlySpan<T> span) =>
		this.span = span;

	public override Boolean Equals(Object? @object) =>
		span.Equals(@object);

	public override Int32 GetHashCode() =>
		span.GetHashCode();

	public override String? ToString() =>
		span.ToString();

	public ReadOnlySpan<T> Value => span.Value;

	private readonly IReadOnlySpan<T> span;
}