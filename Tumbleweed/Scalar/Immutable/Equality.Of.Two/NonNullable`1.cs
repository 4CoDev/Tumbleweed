using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Scalar.Immutable.Casted.Convertee;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Immutable = Tumbleweed.Scalar.Immutable;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Scalar.Immutable.Equality.Of.Two;

public sealed class NonNullable<T> : Envelope
{
	public NonNullable
	(
		System::Object first,
		System::Object second
	) : this
	(
		new Object<T>(first),
		new Object<T>(second)
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