using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using Tumbleweed.Boolean.Comparison.Both.Are;
using Tumbleweed.Subroutine.Function.Nullary.Equality.Structural.Of;

namespace DotGod.Node.Spatial.Batch.Entities.Equality;

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
			new Two<Tumbleweed.Scalar.Nullable.Any<Godot.Node>>(
				() => first.Node,
				() => second.Node),
			new Two<Geometry.Spatial.Concave.Graphical.Mesh.Any>(
				() => first.Mesh,
				() => second.Mesh))
	)
	{
	}
}