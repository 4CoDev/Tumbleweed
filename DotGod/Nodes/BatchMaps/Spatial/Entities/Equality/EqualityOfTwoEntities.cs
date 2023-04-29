using DotGod.Geometrics.Graphical.Meshes;
using Godot;
using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Delegates.Functions.Nullary.Equality.ByValues;
using Tumbleweed.Nullability;

namespace DotGod.Nodes.BatchMaps.Spatial.Entities.Equality;

public sealed class EqualityOfTwoEntities : BooleanEnvelope
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
		new AndOfTwoBooleans(
			new EqualityOfTwoFunctions<INullable<Node>>(
				() => first.Node,
				() => second.Node),
			new EqualityOfTwoFunctions<IMesh>(
				() => first.Mesh,
				() => second.Mesh))
	)
	{
	}
}