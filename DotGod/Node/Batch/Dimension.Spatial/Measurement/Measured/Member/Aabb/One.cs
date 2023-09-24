namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Member.Aabb;

public sealed class One : Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Envelope
{
	public One(Any batch) : base
	(
		new Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Function.Result.One(
			() => batch.Aabb)
	)
	{
	}
}