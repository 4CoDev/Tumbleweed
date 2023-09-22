namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Measured.With.Aabb;

public sealed class One : Measurement.Measured.Envelope
{
	public One
	(
		Any batch,
		Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Any aabb
	) : base
	(
		new Measurement.Measured.With.Members.One
		(
			new Subbatch.Array.One(batch),
			new Member.Entity.Collection.One(batch),
			aabb
		)
	)
	{
	}
}