using DotGod.Node.Spatial.Batch.Space.Points;
using DotGod.Point.Spatial.Transformed;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Spatial.Batch.Space;

public sealed class TransformedSpace : SpaceEnvelope
{
	public TransformedSpace
	(
		ISpace space,
		Transform3D transform
	) : this
	(
		space,
		new Value<Transform3D>(transform)
	)
	{
	}
	
	public TransformedSpace
	(
		ISpace space,
		Any<Transform3D> transform
	) : base
	(
		new SpaceWithPoints(
			new One(new FromPointOfSpace(space), transform),
			new One(new ToPointOfSpace(space), transform))
	)
	{
	}
}