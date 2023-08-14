namespace DotGod.Node.Batch.Dimension.Spatial.Measured.From.Unmeasured;

public sealed class One : Envelope
{
	public One
	(
		Spatial.Unmeasured.Any batch,
		Tumbleweed.Geometry.Spatial.Aabb.Any aabb
	) : base
	(
		new Measured.With.Members.One
		(
			new Spatial.Unmeasured.Subbatch.Array.One(batch),
			new Entity.Collection.One(batch),
			aabb
		)
	)
	{
	}
}