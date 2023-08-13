using NaturalPoint = Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Natural.Any>;
using One = DotGod.Node.Batch.Dimension.Spatial.Spaced.From.Unspaced.With.Space.One;

namespace DotGod.Node.Batch.Dimension.Spatial.Spaced.Subbatch.NonNullable.At.Index;

public sealed class One : Envelope
{
	public One
	(
		Any batch,
		NaturalPoint index
	) : base
	(
		new From.Unspaced.With.Space.One(
			new Node.Batch.Dimension.Spatial.Unspaced.Subbatch.NonNullable.At.Index.One(batch, index),
			new Space.Octant.At.Index.One(batch, index))
	)
	{
	}
}