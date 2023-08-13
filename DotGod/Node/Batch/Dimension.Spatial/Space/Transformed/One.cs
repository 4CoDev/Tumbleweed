using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using Actual = DotGod.Node.Batch.Dimension.Spatial.Space.Point.B.Actual;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any space,
		Transform3D transform
	) : this
	(
		space,
		new Value<Transform3D>(transform)
	)
	{
	}
	
	public One
	(
		Any space,
		Any<Transform3D> transform
	) : base
	(
		new With.Points.One(
			new DotGod.Point.Spatial.Transformed.One(new Point.A.Actual(space), 
			transform),
			new DotGod.Point.Spatial.Transformed.One(new Actual(space), transform))
	)
	{
	}
}