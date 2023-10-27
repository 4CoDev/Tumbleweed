using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;
using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Bounding.Else.Initial.Aabb;

public sealed class One : Measured.Envelope
{
	public One
	(
		Measured.Any initial,
		Aabb::Any aabb
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
		Batch::Any initial,
		Aabb::Any aabb
	) =>
	(
		Function(
			initial,
			new Measured.Subbatch.NonNullable.Collided.By.Aabb.Point.A.One
				(initial, aabb),
			aabb)
	);
	
	private static Measured.Any Function
	(
		Batch::Any initial,
		Batch::Any subbatch,
		Aabb::Any aabb
	)
	{
		if (new Measured.Is.Outside.Aabb.One(subbatch, aabb).State)
			return initial;
		return new Bounding.Else.Initial.Aabb.One(subbatch, aabb);
	}
}