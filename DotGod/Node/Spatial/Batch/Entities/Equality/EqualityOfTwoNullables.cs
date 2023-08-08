using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.As;
using Tumbleweed.Scalar.Nullable.From.System;

namespace DotGod.Node.Spatial.Batch.Entities.Equality;

public sealed class EqualityOfTwoNullables : Tumbleweed.Boolean.Envelope
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
		new Type<ISpatialEntity>(first),
		new Type<ISpatialEntity>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		ISpatialEntity? first,
		ISpatialEntity? second
	) : this
	(
		new One<ISpatialEntity>(first),
		new One<ISpatialEntity>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		Any<ISpatialEntity> first,
		Any<ISpatialEntity> second
	) : base
	(
		new Tumbleweed.Boolean.Function.Result(
			() => Function(first, second))
	)
	{
	}

	private static Tumbleweed.Boolean.Any Function
	(
		Any<ISpatialEntity> first,
		Any<ISpatialEntity> second
	)
	{
		if (first.HasValue.State && second.HasValue.State)
			return new EqualityOfTwoEntities(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}