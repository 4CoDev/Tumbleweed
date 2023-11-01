using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Property.Output.Casted.Convertee;

using System = System;
using Property = Tumbleweed.Property.Output;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Property.Output.Equality.Of.Two;

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
		Property::Any<T> first,
		Property::Any<T> second
	) : base
	(
		new Function::Equality.Structural.Of.Two<T>(
			() => first.Value,
			() => second.Value)
	)
	{
	}
}