namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Member.Aabb;

public sealed class One : Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Envelope
{
	public One(Any batch) : base
	(
		new Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Function.Result.One(
			() => batch.Aabb)
	)
	{
	}
}