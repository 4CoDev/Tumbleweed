using DotGod.Node.Batch.Dimension.Spatial.Unmeasured;

namespace DotGod.Node.Batch.Dimension.Spatial.Measured.Bounding.Just.Aabb;

public sealed class One : Unmeasured.Envelope
{
	public One
	(
		Measured.Any batch,
		Tumbleweed.Geometry.Spatial.Aabb.Any aabb
	) : base
	(
		new Unmeasured.Function.Result.One(
			() => Function(batch, aabb))
	)
	{
	}

	private static Unmeasured.Any Function
	(
		Measured.Any batch,
		Tumbleweed.Geometry.Spatial.Aabb.Any space
	)
	{
		if (!new Measured.Is.Outside.Aabb.One(batch, space).State)
			throw new InvalidOperationException(
				"The space is not inside the batch.");
		return new Else.Initial.Aabb.One(batch, space);
	}
}