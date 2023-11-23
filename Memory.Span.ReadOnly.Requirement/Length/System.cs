using Tumbleweed.Property.Output.With.Value;
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
		new One<Int32>(size)
	)
	{
	}
	
	public System
	(
		ReadOnlySpan.Any<T> span,
		Property.Output.Any<Int32> size
	) : base
	(
		new ReadOnlySpan.Function.Result<T>(
			() => Function(span, size))
	)
	{
	}

	private static ReadOnlySpan.Any<T> Function
	(
		ReadOnlySpan.Any<T> span, Property.Output.Any<Int32> size
	)
	{
		if (span.AsSystem.Length == size.Value) return span;
		throw new InvalidOperationException("ReadOnlySpan size is wrong.");
	}
}