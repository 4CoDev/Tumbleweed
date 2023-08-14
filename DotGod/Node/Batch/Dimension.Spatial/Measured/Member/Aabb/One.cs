namespace DotGod.Node.Batch.Dimension.Spatial.Measured.Member.Aabb;

public sealed class One : Tumbleweed.Geometry.Spatial.Aabb.Envelope
{
	public One(Any batch) : base
	(
		new Tumbleweed.Geometry.Spatial.Aabb.Function.Result.One(
			() => batch.Aabb)
	)
	{
	}
}