using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical.Entities.Equality;

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
		IBakingEntity? first,
		IBakingEntity? second
	) : this
	(
		new ScalarOfValue<IBakingEntity?>(first),
		new ScalarOfValue<IBakingEntity?>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IScalar<IBakingEntity?> first,
		IScalar<IBakingEntity?> second
	) : base
	(
		new BitOfDelegate(
			() => Function(
				first.Value,
				second.Value))
	)
	{
	}

	private static IBit Function
	(
		IBakingEntity? first,
		IBakingEntity? second
	)
	{
		if (first != null && second != null)
			return new EqualityOfTwoEntities(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}