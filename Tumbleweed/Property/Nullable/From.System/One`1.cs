using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Mathematics.Boolean.System.Function.Result;
using Nullable = Tumbleweed.Property.Nullable;
using Property = Tumbleweed.Property.Output;


namespace Tumbleweed.Property.Nullable.From.System;

public sealed class One<T> : Nullable::Envelope<T>
{
	public One(T? value) : this
	(
		new Property::With.Value<T?>(value)
	)
	{
	}
	
	public One(Property::Any<T?> property) : base
	(
		new Nullable::With.Members<T>(
			property!,
			new One(
				new Actual(
					() => property.Value != null)))
	)
	{
	}
}