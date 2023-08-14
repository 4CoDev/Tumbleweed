namespace DotGod.Node.Batch.Dimension.Spatial.Measured.Bounding.Else.Initial.Entity;

public sealed class One : Unmeasured.Envelope
{
	public One
	(
		Measured.Any initial,
		Spatial.Entity.Any entity
	) : base
	(
		new Else.Initial.Aabb.One(
			initial,
			new Spatial.Entity.Space.One(entity))
	)
	{
	}
}