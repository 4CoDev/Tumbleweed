using Tumbleweed.Mathematics.Boolean.Function.Result;
using Tumbleweed.Property.Nullable;
using Tumbleweed.Property.Nullable.As;
using Tumbleweed.Property.Nullable.From.System;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Equality;

public sealed class EqualityOfTwoNullables : Tumbleweed.Mathematics.Boolean.Envelope
{
	public EqualityOfTwoNullables
	(
		Object? first,
		Object? second
	) : this
	(
		new One<Object>(first),
		new One<Object>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		Any<Object> first,
		Any<Object> second
	) : this
	(
		new Type<Any>(first),
		new Type<Any>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		Any? first,
		Any? second
	) : this
	(
		new One<Any>(first),
		new One<Any>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		Any<Any> first,
		Any<Any> second
	) : base
	(
		new Actual(
			() => Function(first, second))
	)
	{
	}

	private static Tumbleweed.Mathematics.Boolean.Any Function
	(
		Any<Any> first,
		Any<Any> second
	)
	{
		if (first.HasValue.State && second.HasValue.State)
			return new EqualityOfTwoEntities(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}