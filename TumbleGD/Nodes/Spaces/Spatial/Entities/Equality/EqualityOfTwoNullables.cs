using Tumbleweed.Bits;
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
		new ScalarOfValue<Object?>(first),
		new ScalarOfValue<Object?>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IScalar<Object?> first,
		IScalar<Object?> second
	) : this
	(
		new NullableAsEntity(first),
		new NullableAsEntity(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		ISpatialEntity? first,
		ISpatialEntity? second
	) : this
	(
		new ScalarOfValue<ISpatialEntity?>(first),
		new ScalarOfValue<ISpatialEntity?>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IScalar<ISpatialEntity?> first,
		IScalar<ISpatialEntity?> second
	) : base
	(
		new BitOfFunction(
			() => Function(
				first.Value,
				second.Value))
	)
	{
	}

	private static IBit Function
	(
		ISpatialEntity? first,
		ISpatialEntity? second
	)
	{
		if (first != null && second != null)
			return new EqualityOfTwoEntities(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}