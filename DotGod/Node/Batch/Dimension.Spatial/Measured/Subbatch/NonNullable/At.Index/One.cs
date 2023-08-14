using NaturalPoint = Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Natural.Any>;

namespace DotGod.Node.Batch.Dimension.Spatial.Measured.Subbatch.NonNullable.At.Index;

public sealed class One : Envelope
{
	public One
	(
		Any batch,
		NaturalPoint index
	) : base
	(
		new From.Unmeasured.One(
			new Unmeasured.Subbatch.NonNullable.At.Index.One(batch, index),
			new Tumbleweed.Geometry.Spatial.Aabb.Octant.At.Index.One(
				new Member.Aabb.One(batch),
				index))
	)
	{
	}
}