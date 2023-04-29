using Tumbleweed.Booleans;
using Tumbleweed.Nullability;
using Tumbleweed.Nullability.FromSystem;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities.Equality;

public sealed class EqualityOfTwoNullables : BooleanEnvelope
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
		new BooleanOfFunction(
			() => Function(first, second))
	)
	{
	}

	private static IBoolean Function
	(
		INullable<ISpatialEntity> first,
		INullable<ISpatialEntity> second
	)
	{
		if (first.Existing.State && second.Existing.State)
			return new EqualityOfTwoEntities(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}