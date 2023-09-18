namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Space;

public sealed class One : Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Envelope
{
	public One(Any entity) : base
	(
		new Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Function.Result.One(
			() => entity.Aabb)
	)
	{
	}
}