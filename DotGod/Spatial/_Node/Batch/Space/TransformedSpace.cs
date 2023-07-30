using DotGod.Spatial._Node.Batch.Space.Points;
using DotGod.Spatial.Point;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Spatial._Node.Batch.Space;

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
			new TransformedPoint(new FromPointOfSpace(space), transform),
			new TransformedPoint(new ToPointOfSpace(space), transform))
	)
	{
	}
}