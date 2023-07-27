using Tumbleweed.Boolean;
using Tumbleweed.Subroutine.Function.Nullary.Equality.Structural;
using Tumbleweed.Subroutine.Function.Nullary.Equality.Structural.Of;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;
using System = System;

namespace Tumbleweed.Scalar.Equality.Of.Two;

public sealed class Values<T> : Envelope
{
	public Values
	(
		System::Object first,
		System::Object second
	) : this
	(
		new Unpacked<T>(first),
		new Unpacked<T>(second)
	)
	{
	}
	
	public Values
	(
		Scalar.Any<T> first,
		Scalar.Any<T> second
	) : base
	(
		new Two<T>(
			() => first.Value,
			() => second.Value)
	)
	{
	}
}