using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Bits;
using Tumbleweed.Bits.Booleans;
using Tumbleweed.Delegates.Functions.Nullary.Equality.ByValues;
using Tumbleweed.Existence;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical.Entities.Equality;

public sealed class EqualityOfTwoEntities : BitEnvelope
{
	public EqualityOfTwoEntities
	(
		Object first,
		Object second
	) : this
	(
		new ObjectAsEntity(first),
		new ObjectAsEntity(second)
	)
	{
	}
	
	public EqualityOfTwoEntities
	(
		IBakingEntity first,
		IBakingEntity second
	) : base
	(
		new BitAndBit(
			new EqualityOfTwoFunctions<IExistence<Node>>(
				() => first.Node,
				() => second.Node),
			new EqualityOfTwoFunctions<IEnumerable<ISurface>>(
				() => first.Mesh,
				() => second.Mesh))
	)
	{
	}
}