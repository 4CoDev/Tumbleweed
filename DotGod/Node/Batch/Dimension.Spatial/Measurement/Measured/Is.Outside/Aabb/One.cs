namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Is.Outside.Aabb;

public sealed class One : Tumbleweed.Mathematics.Boolean.Envelope
{
	public One
	(
		Any batch,
		Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Any aabb
	) : base
	(
		new Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Is.Inside.Other.One(
			aabb,
			new Member.Aabb.One(batch))
	)
	{
	}
}