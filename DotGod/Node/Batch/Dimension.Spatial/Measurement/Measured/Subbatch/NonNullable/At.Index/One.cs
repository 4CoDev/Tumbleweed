using NaturalPoint = Tumbleweed.Point.Spatial.Generic.Any<Tumbleweed.Mathematics.Number.Natural.Any>;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Subbatch.NonNullable.At.Index;

public sealed class One : Envelope
{
	public One
	(
		Any batch,
		NaturalPoint index
	) : base
	(
		new Unmeasured.Measured.With.Aabb.One(
			new Unmeasured.Subbatch.NonNullable.At.Index.One(batch, index),
			new Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.At.Index.One(
				new Member.Aabb.One(batch),
				index))
	)
	{
	}
}