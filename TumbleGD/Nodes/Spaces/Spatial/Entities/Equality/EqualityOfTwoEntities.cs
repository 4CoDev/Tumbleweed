using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Bits;
using Tumbleweed.Bits.Booleans;
using Tumbleweed.Delegates.Functions.Nullary.Equality.ByValues;
using Tumbleweed.Nullability;

namespace TumbleGD.Nodes.Spaces.Spatial.Entities.Equality;

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
		ISpatialEntity first,
		ISpatialEntity second
	) : base
	(
		new BitAndBit(
			new EqualityOfTwoFunctions<INullable<Node>>(
				() => first.Node,
				() => second.Node),
			new EqualityOfTwoFunctions<IEnumerable<ISurface>>(
				() => first.Mesh,
				() => second.Mesh))
	)
	{
	}
}