namespace DotGod.Node.Batch.Dimension.Spatial.Measured.Bounding.Else.Initial.Aabb;

public sealed class One : Unmeasured.Envelope
{
	public One
	(
		Measured.Any initial,
		Tumbleweed.Geometry.Spatial.Aabb.Any aabb
	) : base
	(
		new Unmeasured.Conditional(
			new Have.Subbatch.Collided.By.Space.Point.A.One(initial, aabb),
			new Unmeasured.Function.Result.One(() => Function(initial, aabb)),
			initial)
	)
	{
	}

	private static Unmeasured.Any Function
	(
		Measured.Any initial,
		Tumbleweed.Geometry.Spatial.Aabb.Any space
	) =>
	(
		Function(
			initial,
			new Measured.Subbatch.NonNullable.Collided.By.Space.Point.A.One(initial, space),
			space)
	);
	
	private static Unmeasured.Any Function
	(
		Unmeasured.Any initial,
		Measured.Any subbatch,
		Tumbleweed.Geometry.Spatial.Aabb.Any space
	)
	{
		if (!new Measured.Is.Outside.Aabb.One(subbatch, space).State) return initial;
		return new One(subbatch, space);
	}
}