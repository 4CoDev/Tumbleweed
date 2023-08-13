using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.With;
using NaturalPoint = Tumbleweed.Point.Spatial.Any<
		Tumbleweed.Number.Natural.Any>;

namespace DotGod.Node.Batch.Dimension.Spatial.Spaced.Subbatch.Nullable.At.Index;

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
			new Unspaced.Have.Subbatch.At.Index.One(batch, index))
	)
	{
	}
}