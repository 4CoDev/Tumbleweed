using Tumbleweed.Mathematics.Comparison.Boolean.Both.Are;
using Tumbleweed.Subroutine.Function.Nullary.Equality.Structural.Of;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Equality;

public sealed class EqualityOfTwoEntities : Tumbleweed.Mathematics.Boolean.Envelope
{
	public EqualityOfTwoEntities
	(
		Object first,
		Object second
	) : this
	(
		new Unboxed(first),
		new Unboxed(second)
	)
	{
	}
	
	public EqualityOfTwoEntities
	(
		Any first,
		Any second
	) : base
	(
		new True(
			new Two<Tumbleweed.Property.Nullable.Any<Godot.Node>>(
				() => first.Node,
				() => second.Node),
			new Two<Mathematics.Geometry.Stereometry.Graphical.Mesh.Any>(
				() => first.Mesh,
				() => second.Mesh))
	)
	{
	}
}