using Godot;
using Boolean = Tumbleweed.Mathematics.Boolean;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;
using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Is.Inside.Aabb;

public sealed class One : Boolean::Envelope
{
	public One
	(
		Batch::Any batch,
		Aabb::Any aabb
	) : base
	(
		new Aabb::Is.Inside.Other.One(
			aabb,
			new Batch::Member.Aabb.One(batch))
	)
	{
	}
}