using DotGod.Geometry.Spatial.Graphical.Meshes;
using Godot;
using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Nullables;
using Tumbleweed.Subroutines.Functions.Nullary.Equality.ByValues;

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