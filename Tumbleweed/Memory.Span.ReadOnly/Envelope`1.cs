using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;
using System = System;

namespace Tumbleweed.Memory.Span.ReadOnly;

public abstract class Envelope<T> : ReadOnlySpan::Any<T>
{
	protected Envelope(ReadOnlySpan::Any<T> span) =>
		this.span = span;

	public override System::Boolean Equals(System::Object? @object) =>
		span.Equals(@object);

	public override Int32 GetHashCode() =>
		span.GetHashCode();

	public override System::String? ToString() =>
		span.ToString();

	public ReadOnlySpan<T> Value =>
		span.Value;

	private readonly ReadOnlySpan::Any<T> span;
}