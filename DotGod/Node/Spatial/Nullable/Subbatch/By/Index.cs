using DotGod.Node.Spatial.Batch;
using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.From.Array.Spatial.At;
using NaturalPoint = Tumbleweed.Point.Spatial.Any<
		Tumbleweed.Number.Natural.Any>;

using SubbatchArrayOfBatch =
	DotGod.Node.Spatial.Nullable.Subbatch.Array.Of.Batch;

namespace DotGod.Node.Spatial.Nullable.Subbatch.By;

public sealed class Index : Envelope<Any>
{
	public Index
	(
		Any batch,
		NaturalPoint index
	) : base
	(
		new Index<Any>(
			new SubbatchArrayOfBatch(batch),
			index)
	)
	{
	}
}