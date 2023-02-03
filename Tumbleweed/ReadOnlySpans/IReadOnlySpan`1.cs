namespace Tumbleweed.ReadOnlySpans;

public interface IReadOnlySpan<T>
{
	ReadOnlySpan<T> Value { get; }
}