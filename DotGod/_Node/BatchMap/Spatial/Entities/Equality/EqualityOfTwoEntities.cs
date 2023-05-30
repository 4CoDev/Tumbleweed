using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Nullable;
using Tumbleweed.Subroutine.Nullary.Function.Equality.ByValues;

namespace DotGod._Node.BatchMap.Spatial.Entities.Equality;

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