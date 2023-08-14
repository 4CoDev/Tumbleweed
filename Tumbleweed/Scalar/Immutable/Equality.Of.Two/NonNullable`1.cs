using Boolean = Tumbleweed.Boolean;
using System = System;
using Immutable = Tumbleweed.Scalar.Immutable;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Scalar.Immutable.Equality.Of.Two;

public sealed class NonNullable<T> : Boolean::Envelope
{
	public NonNullable
	(
		System::Object first,
		System::Object second
	) : this
	(
		new Immutable::Unboxed<T>(first),
		new Immutable::Unboxed<T>(second)
	)
	{
	}
	
	public NonNullable
	(
		Immutable::Any<T> first,
		Immutable::Any<T> second
	) : base
	(
		new Function::Equality.Structural.Of.Two<T>(
			() => first.Value,
			() => second.Value)
	)
	{
	}
}