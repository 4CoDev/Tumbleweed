using System = System;

namespace Tumbleweed.Scalar;

public abstract class Envelope<T> : Any<T>
{
	protected Envelope(Any<T> scalar) =>
		this.scalar = scalar;

	public T Value => scalar.Value;

	public override System::Boolean Equals(System::Object? other) =>
		scalar.Equals(other);

	public override Int32 GetHashCode() =>
		scalar.GetHashCode();

	public override System::String? ToString() =>
		scalar.ToString();

	private readonly Any<T> scalar;
}