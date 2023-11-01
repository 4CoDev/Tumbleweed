using Tumbleweed.Enumerable;
using Tumbleweed.Property.Nullable;
using Tumbleweed.Property.Nullable.From.System;

namespace Tumbleweed.String.Spare.When.Null;

public sealed class Multiple : Enumerable.Envelope<Any>
{
	public Multiple
	(
		IEnumerable<System.String?> nullables,
		System.String spare
	) : this
	(
		new From.System.Nullable.Multiple(nullables),
		new From.System.NonNullable.One(spare)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Any?> nullables,
		Any spare
	) : this
	(
		new Multiple<Any>(nullables),
		spare
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Any<Any>> nullables,
		Any spare
	) : base
	(
		new Selected<Any<Any>, Any>(
			nullables,
			nullable => Expression(nullable, spare))
	)
	{
	}

	private static Any Expression
	(
		Any<Any> nullable,
		Any spare
	) =>
	(
		new One(nullable, spare)
	);
}