using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.With;
using NaturalPoint = Tumbleweed.Mathematics.Vector.Spatial.Generic.Any<
		Tumbleweed.Mathematics.Number.Natural.Any>;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Subbatch.Nullable.At.Index;

public sealed class One : Envelope<Any>
{
	public One
	(
		Any batch,
		NaturalPoint index
	) : base
	(
		new Members<Any>(
			new NonNullable.At.Index.One(batch, index),
			new Unmeasured.Have.Subbatch.At.Index.One(batch, index))
	)
	{
	}
}