using DotGod.Spatial._Node.Batch;
using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.From.Array.Spatial.At;
using NullableEnvelope = Tumbleweed.Scalar.Nullable.Envelope<
		DotGod.Spatial._Node.Batch.Any>;
using NaturalPoint = Tumbleweed.Point.Spatial.Any<
		Tumbleweed.Number.Natural.Any>;

using SubbatchArrayOfBatch =
	DotGod.Spatial._Node.Nullable.Subbatch.Array.Of.Batch;

namespace DotGod.Spatial._Node.Nullable.Subbatch.By;

public sealed class Index : Envelope<Any>
{
	public Index
	(
		Any batch,
		NaturalPoint index
	) : base
	(
		new Index<Batch.Any>(
			new SubbatchArrayOfBatch(batch),
			index)
	)
	{
	}
}