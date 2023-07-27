using NaturalPoint = Tumbleweed.Point.Spatial.Any<
		Tumbleweed.Number.Natural.Any>;
using SubbatchFromBatchByIndex =
	DotGod.Spatial._Node.Batch.Subbatch.By.Index;

using OctantFromBatchByIndex =
	DotGod.Spatial._Node.Batch.Space.Octants.OctantWithIndex;

namespace DotGod.Spatial._Node.Spaced.Batch.Subbatch.By;

public sealed class Index : Envelope
{
	public Index
	(
		Abstract.IBatch batch,
		NaturalPoint index
	) : base
	(
		new WithSpace(
			new SubbatchFromBatchByIndex(batch, index),
			new OctantFromBatchByIndex(batch, index))
	)
	{
	}
}