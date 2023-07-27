using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Memory.Span.ReadOnly.With.Size;

public sealed class Statement<T> : ReadOnlySpan.Envelope<T>
{
	public Statement
	(
		ReadOnlySpan.Any<T> span,
		Int32 size
	) : this
	(
		span,
		new Scalar.Of.Value<Int32>(size)
	)
	{
	}
	
	public Statement
	(
		ReadOnlySpan.Any<T> span,
		Scalar.Any<Int32> size
	) : base
	(
		new ReadOnlySpan.Function.Result<T>(
			() => Function(span, size))
	)
	{
	}

	private static ReadOnlySpan.Any<T> Function
	(
		ReadOnlySpan.Any<T> span,
		Scalar.Any<Int32> size
	)
	{
		if (span.Value.Length == size.Value) return span;
		throw new InvalidOperationException("ReadOnlySpan size is wrong.");
	}
}