using Tumbleweed.Scalar.Immutable.With;
using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

namespace Tumbleweed.Memory.Span.ReadOnly.Requirement.Length;

public sealed class System<T> : ReadOnlySpan.Envelope<T>
{
	public System
	(
		ReadOnlySpan.Any<T> span,
		Int32 size
	) : this
	(
		span,
		new Value<Int32>(size)
	)
	{
	}
	
	public System
	(
		ReadOnlySpan.Any<T> span,
		Scalar.Immutable.Any<Int32> size
	) : base
	(
		new ReadOnlySpan.Function.Result<T>(
			() => Function(span, size))
	)
	{
	}

	private static ReadOnlySpan.Any<T> Function
	(
		ReadOnlySpan.Any<T> span, Scalar.Immutable.Any<Int32> size
	)
	{
		if (span.Value.Length == size.Value) return span;
		throw new InvalidOperationException("ReadOnlySpan size is wrong.");
	}
}