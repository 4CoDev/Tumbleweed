using DotGod.Node.Batch.Dimension.Spatial.Unmeasured;

namespace DotGod.Node.Batch.Dimension.Spatial.Measured.Bounding.Just.Entity;

public sealed class One : Unmeasured.Envelope
{
	public One
	(
		Measured.Any batch,
		Spatial.Entity.Any entity
	) : base
	(
		new Aabb.One(
			batch,
			new Spatial.Entity.Space.One(entity))
	)
	{
	}
}