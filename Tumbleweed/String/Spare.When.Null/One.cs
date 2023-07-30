using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.From.System;

namespace Tumbleweed.String.Spare.When.Null;

public sealed class One : Envelope
{
	public One
	(
		System.String? nullable,
		System.String spare
	) : this
	(
		new From.System.Nullable.One(nullable),
		new From.System.NonNullable.One(spare)
	)
	{
	}
	
	public One
	(
		Any<System.String> nullable,
		System.String spare
	) : this
	(
		new From.System.Nullable.One(nullable),
		spare
	)
	{
	}
	
	public One
	(
		Any<Any> nullable,
		System.String spare
	) : this
	(
		nullable,
		new From.System.NonNullable.One(spare)
	)
	{
	}
	
	public One
	(
		Any? nullable,
		Any spare
	) : this
	(
		new One<Any>(nullable),
		spare
	)
	{
	}
	
	public One
	(
		Any<Any> nullable,
		Any spare
	) : base
	(
		new ScalarValue(
			new Scalar.Nullable.Spare.When.Null<Any>(nullable, spare))
	)
	{
	}
}