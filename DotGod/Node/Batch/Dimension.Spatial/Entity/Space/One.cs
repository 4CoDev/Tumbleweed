namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Space;

public sealed class One : Tumbleweed.Geometry.Spatial.Aabb.Envelope
{
	public One(Any entity) : base
	(
		new Tumbleweed.Geometry.Spatial.Aabb.Function.Result.One(
			() => entity.Occupation)
	)
	{
	}
}