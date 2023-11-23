using Tumbleweed.Property.Option;
using Tumbleweed.Property.Option.From.System;

namespace Tumbleweed.String.Operation.Spare.When.Null;

public sealed class One : Envelope
{
	public One
	(
		System.String? option,
		System.String spare
	) : this
	(
		new From.System.Option.One(option),
		new From.System.NonNullable.One(spare)
	)
	{
	}
	
	public One
	(
		Any<System.String> option,
		System.String spare
	) : this
	(
		new From.System.Option.One(option),
		spare
	)
	{
	}
	
	public One
	(
		Any<Any> option,
		System.String spare
	) : this
	(
		option,
		new From.System.NonNullable.One(spare)
	)
	{
	}
	
	public One
	(
		Any? option,
		Any spare
	) : this
	(
		new One<Any>(option),
		spare
	)
	{
	}
	
	public One
	(
		Any<Any> option,
		Any spare
	) : base
	(
		new String.Property.Value.Actual(
			new Tumbleweed.Property.Option.Spare.When.Null.One<Any>(
				option,
				spare))
	)
	{
	}
}