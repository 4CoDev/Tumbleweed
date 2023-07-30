using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Scalar.Immutable;

public abstract class Envelope<T> : Immutable::Any<T>
{
	protected Envelope(Immutable::Any<T> scalar) =>
		this.scalar = scalar;

	public T Value => scalar.Value;

	public override System::Boolean Equals
	(
		System::Object? other
	) =>
	(
		scalar.Equals(other)
	);

	public override System::Int32 GetHashCode() =>
		scalar.GetHashCode();

	public override System::String? ToString() =>
		scalar.ToString();

	private readonly Immutable::Any<T> scalar;
}