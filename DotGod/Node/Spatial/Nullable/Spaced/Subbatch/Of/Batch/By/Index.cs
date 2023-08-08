using DotGod.Node.Spatial.Spaced.Abstract;
using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.With;
using NaturalPoint = Tumbleweed.Point.Spatial.Any<
		Tumbleweed.Number.Natural.Any>;

using SubbatchOfBatchByIndex =
	DotGod.Node.Spatial.Spaced.Batch.Subbatch.By.Index;

using BatchHaveSubbatchByIndex =
	DotGod.Node.Spatial.Batch.Have.Subbatch.By.Index;

namespace DotGod.Node.Spatial.Nullable.Spaced.Subbatch.Of.Batch.By;

public sealed class Index : Envelope<IBatch>
{
	public Index
	(
		IBatch batch,
		NaturalPoint index
	) : base
	(
		new Members<IBatch>(
			new SubbatchOfBatchByIndex(batch, index),
			new BatchHaveSubbatchByIndex(batch, index))
	)
	{
	}
}