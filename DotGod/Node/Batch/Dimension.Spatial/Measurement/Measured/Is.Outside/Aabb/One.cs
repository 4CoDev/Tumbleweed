using Boolean = Tumbleweed.Mathematics.Boolean;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;
using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Is.Outside.Aabb;

public sealed class One : Boolean::Envelope
{
	public One
	(
		Batch::Any batch,
		Aabb::Any aabb
	) : base
	(
		new Boolean::Not(
			new Batch::Is.Inside.Aabb.One(batch, aabb))
	)
	{
	}
}