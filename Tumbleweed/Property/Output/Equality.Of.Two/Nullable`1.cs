using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.Function.Result;
using Tumbleweed.Object.Equality.ByReference;

using System = System;
using Nullable = Tumbleweed.Property.Nullable;
using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Property.Output.Equality.Of.Two;

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
		new Nullable::As.Type<Property::Any<T>>(first),
		new Nullable::As.Type<Property::Any<T>>(second)
	)
	{
	}
	
	public Nullable
	(
		Property::Any<T>? first,
		Property::Any<T>? second
	) : this
	(
		new Nullable::From.System.One<Property::Any<T>>(first),
		new Nullable::From.System.One<Property::Any<T>>(second)
	)
	{
	}
	
	public Nullable
	(
		Nullable::Any<Property::Any<T>> first,
		Nullable::Any<Property::Any<T>> second
	) : base
	(
		new Actual(
			() => Function(first, second))
	)
	{
	}

	private static Any Function
	(
		Nullable::Any<Property::Any<T>> first,
		Nullable::Any<Property::Any<T>> second
	)
	{
		if (first.HasValue.State && second.HasValue.State)
			return new Property::Equality.Of.Two.NonNullable<T>(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}