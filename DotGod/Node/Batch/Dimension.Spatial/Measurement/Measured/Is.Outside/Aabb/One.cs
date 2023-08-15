namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Is.Outside.Aabb;

public sealed class One : Tumbleweed.Boolean.Envelope
{
	public One
	(
		Any batch,
		Tumbleweed.Geometry.Spatial.Aabb.Any aabb
	) : base
	(
		new Tumbleweed.Geometry.Spatial.Aabb.Is.Inside.Other.One(
			aabb,
			new Member.Aabb.One(batch))
	)
	{
	}
}