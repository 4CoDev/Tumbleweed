using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Mathematics.Boolean.System.Function.Result;
using Option = Tumbleweed.Property.Option;
using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Property.Option.From.System;

public sealed class One<T> : Option::Envelope<T>
{
	public One(T? value) : this
	(
		new Property::With.Value.One<T?>(value)
	)
	{
	}
	
	public One(Property::Any<T?> property) : base
	(
		new Option::With.Member.Definition.One<T>(
			property!,
			new One(
				new Actual(
					() => property.Value != null)))
	)
	{
	}
}