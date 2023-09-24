using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Object.Equality.ByReference;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Nullable = Tumbleweed.Scalar.Nullable;
using Immutable = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Scalar.Immutable.Equality.Of.Two;

public sealed class Nullable<T> : Envelope
{
	public Nullable
	(
		System::Object? first,
		System::Object? second
	) : this
	(
		new Nullable::From.System.One<System::Object>(first),
		new Nullable::From.System.One<System::Object>(second)
	)
	{
	}
	
	public Nullable
	(
		Nullable::Any<System::Object> first,
		Nullable::Any<System::Object> second
	) : this
	(
		new Nullable::As.Type<Immutable::Any<T>>(first),
		new Nullable::As.Type<Immutable::Any<T>>(second)
	)
	{
	}
	
	public Nullable
	(
		Immutable::Any<T>? first,
		Immutable::Any<T>? second
	) : this
	(
		new Nullable::From.System.One<Immutable::Any<T>>(first),
		new Nullable::From.System.One<Immutable::Any<T>>(second)
	)
	{
	}
	
	public Nullable
	(
		Nullable::Any<Immutable::Any<T>> first,
		Nullable::Any<Immutable::Any<T>> second
	) : base
	(
		new Boolean::Function.Result(
			() => Function(first, second))
	)
	{
	}

	private static Any Function
	(
		Nullable::Any<Immutable::Any<T>> first,
		Nullable::Any<Immutable::Any<T>> second
	)
	{
		if (first.HasValue.State && second.HasValue.State)
			return new Immutable::Equality.Of.Two.NonNullable<T>(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}