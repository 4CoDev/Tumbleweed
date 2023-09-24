using Tumbleweed.Mathematics.Boolean;
using Immutable = Tumbleweed.Scalar.Immutable;
using Nullable = Tumbleweed.Scalar.Nullable;
using System = System;
using Boolean = Tumbleweed.Boolean;

namespace Tumbleweed.Scalar.Nullable.Scalar.Value;

public sealed class One<T> : Nullable::Any<T>
{
	public One
	(
		Immutable::Any<Nullable::Any<T>> scalar
	)
	{
		this.scalar = scalar;
	}

	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		scalar.Value.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		scalar.Value.GetHashCode();

	public override System::String? ToString() =>
		scalar.Value.ToString();

	public T Value =>
		scalar.Value.Value;

	public Any HasValue =>
		scalar.Value.HasValue;

	private readonly Immutable::Any<Nullable::Any<T>> scalar;
}