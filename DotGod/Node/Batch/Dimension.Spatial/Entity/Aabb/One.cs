namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Aabb;

public sealed class One : Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Envelope
{
	public One(Any entity) : base
	(
		new Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Function.Result.One(
			() => entity.Aabb)
	)
	{
	}
}