namespace Tumbleweed.ReadOnlySpan;

public interface IReadOnlySpan<T>
{
	ReadOnlySpan<T> Value { get; }
}