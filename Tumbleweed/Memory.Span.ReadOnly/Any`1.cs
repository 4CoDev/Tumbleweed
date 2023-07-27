namespace Tumbleweed.Memory.Span.ReadOnly;

public interface Any<T>
{
	global::System.ReadOnlySpan<T> Value { get; }
}