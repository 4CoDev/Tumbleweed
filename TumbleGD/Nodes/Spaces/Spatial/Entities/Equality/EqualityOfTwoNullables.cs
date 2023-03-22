using Tumbleweed.Bits;
using Tumbleweed.Nullability;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities.Equality;

public sealed class EqualityOfTwoNullables : BitEnvelope
{
	public EqualityOfTwoNullables
	(
		Object? first,
		Object? second
	) : this
	(
		new NullableFromSystem<Object>(first),
		new NullableFromSystem<Object>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		INullable<Object> first,
		INullable<Object> second
	) : this
	(
		new NullableAsType<ISpatialEntity>(first),
		new NullableAsType<ISpatialEntity>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		ISpatialEntity? first,
		ISpatialEntity? second
	) : this
	(
		new NullableFromSystem<ISpatialEntity>(first),
		new NullableFromSystem<ISpatialEntity>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		INullable<ISpatialEntity> first,
		INullable<ISpatialEntity> second
	) : base
	(
		new BitOfFunction(
			() => Function(first, second))
	)
	{
	}

	private static IBit Function
	(
		INullable<ISpatialEntity> first,
		INullable<ISpatialEntity> second
	)
	{
		if (first.Exists.State && second.Exists.State)
			return new EqualityOfTwoEntities(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}