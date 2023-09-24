using Tumbleweed.Mathematics.Boolean.Literal;
using Nullable = Tumbleweed.Scalar.Nullable;
using Immutable = Tumbleweed.Scalar.Immutable;
using Boolean = Tumbleweed.Boolean;

namespace Tumbleweed.Scalar.Nullable.With.Value;

public sealed class One<T> : Nullable::Envelope<T>
{
	public One(T value) : this
	(
		new Immutable::With.Value<T>(value)
	)
	{
	}
	
	public One(Immutable::Any<T> value) : base
	(
		new Nullable::With.Members<T>(
			value,
			new True()))
	{
	}
}