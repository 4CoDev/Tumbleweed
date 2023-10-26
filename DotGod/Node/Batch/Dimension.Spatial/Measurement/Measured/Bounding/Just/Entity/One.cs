namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Bounding.Just.Entity;

public sealed class One : Measured.Envelope
{
	public One
	(
		Measured.Any batch,
		Spatial.Entity.Any entity
	) : base
	(
		new Aabb.One(
			batch,
			new Spatial.Entity.Aabb.One(entity))
	)
	{
	}
}