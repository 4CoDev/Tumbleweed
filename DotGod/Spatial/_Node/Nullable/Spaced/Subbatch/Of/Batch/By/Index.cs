using DotGod.Spatial._Node.Spaced.Abstract;
using Tumbleweed.Nullable;
using NullableSpacedBatchEnvelope = Tumbleweed.Nullable.Envelope<
		DotGod.Spatial._Node.Spaced.Abstract.IBatch>;
using NaturalPoint = Tumbleweed.Point.Spatial.Any<
		Tumbleweed.Number.Natural.Any>;

using SubbatchOfBatchByIndex =
	DotGod.Spatial._Node.Spaced.Batch.Subbatch.By.Index;

using BatchHaveSubbatchByIndex =
	DotGod.Spatial._Node.Batch.Have.Subbatch.By.Index;

namespace DotGod.Spatial._Node.Nullable.Spaced.Subbatch.Of.Batch.By;

public sealed class Index : Envelope<IBatch>
{
	public Index
	(
		_Node.Spaced.Abstract.IBatch batch,
		NaturalPoint index
	) : base
	(
		new Tumbleweed.Nullable.With.Members<IBatch>(
			new SubbatchOfBatchByIndex(batch, index),
			new BatchHaveSubbatchByIndex(batch, index))
	)
	{
	}
}