using Mutable = Tumbleweed.Scalar.Mutable;
using Immutable = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Scalar.Mutable.Scalar.Value;

public sealed class One<T> : Mutable::Any<T>
{
	public One(Immutable::Any<Mutable::Any<T>> scalar) =>
		this.scalar = scalar;

	public T Value
	{
		get => scalar.Value.Value;
		set => scalar.Value.Value = value;
	}

	private readonly Immutable::Any<Mutable::Any<T>> scalar;
}