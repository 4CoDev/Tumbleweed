namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Member.Aabb;

public sealed class One : Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Envelope
{
	public One(Any batch) : base
	(
		new Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Function.Result.One(
			() => batch.Aabb)
	)
	{
	}
}