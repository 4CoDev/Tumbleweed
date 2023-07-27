using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Tumbleweed.Boolean;
using Tumbleweed.Boolean.Comparison.Both.Are;
using Tumbleweed.Nullable;
using Tumbleweed.Subroutine.Function.Nullary.Equality.Structural;
using Tumbleweed.Subroutine.Function.Nullary.Equality.Structural.Of;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

namespace DotGod.Spatial._Node.Batch.Entities.Equality;

public sealed class EqualityOfTwoEntities : Tumbleweed.Boolean.Envelope
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
		new True(
			new Two<Any<Godot.Node>>(
				() => first.Node,
				() => second.Node),
			new Two<IMesh>(
				() => first.Mesh,
				() => second.Mesh))
	)
	{
	}
}