namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Bounding.Else.Initial.Aabb;

public sealed class One : Measured.Envelope
{
	public One
	(
		Measured.Any initial,
		Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Any aabb
	) : base
	(
		new Measured.Conditional(
			new Have.Subbatch.Collided.By.Space.Point.A.One(initial, aabb),
			new Measured.Function.Result.One(
				() => Function(initial, aabb)),
			initial)
	)
	{
	}

	private static Measured.Any Function
	(
		Measured.Any initial,
		Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Any space
	) =>
	(
		Function(
			initial,
			new Measured.Subbatch.NonNullable.Collided.By.Space.Point.A.One(initial, space),
			space)
	);
	
	private static Measured.Any Function
	(
		Measured.Any initial,
		Measured.Any subbatch,
		Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Any space
	)
	{
		if (!new Measured.Is.Outside.Aabb.One(subbatch, space).State) return initial;
		return new One(subbatch, space);
	}
}