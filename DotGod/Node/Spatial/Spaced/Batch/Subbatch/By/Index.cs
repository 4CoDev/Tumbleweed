using NaturalPoint = Tumbleweed.Point.Spatial.Any<
		Tumbleweed.Number.Natural.Any>;
using SubbatchFromBatchByIndex =
	DotGod.Node.Spatial.Batch.Subbatch.By.Index;

using OctantFromBatchByIndex =
	DotGod.Node.Spatial.Batch.Space.Octants.OctantWithIndex;

namespace DotGod.Node.Spatial.Spaced.Batch.Subbatch.By;

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