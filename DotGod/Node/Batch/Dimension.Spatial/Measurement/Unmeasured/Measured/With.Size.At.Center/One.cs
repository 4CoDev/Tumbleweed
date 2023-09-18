using Tumbleweed.Point.Spatial.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Measured.With.Size.At.Center;

public sealed class One : Measurement.Measured.Envelope
{
	public One
	(
		Any batch,
		Any<Tumbleweed.Number.Real.Any> size
	) : base
	(
		new With.Aabb.One(
			batch,
			new Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.With.Size.At.Center.One(size))
	)
	{
	}
}