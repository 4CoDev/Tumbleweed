using DotGod.Spatial._Node.Batch.Space.Octants;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial._Node.Spaced.Batch;

using INaturalNumber = INatural;
using UnspacedSubbatchWithIndex = _Node.Batch.SubbatchWithIndex;

public sealed class SubbatchWithIndex : BatchEnvelope
{
	public SubbatchWithIndex
	(
		ISpacedBatch batch,
		IPoint<INaturalNumber> index
	) : base
	(
		new BatchWithSpace(
			new UnspacedSubbatchWithIndex(batch, index),
			 new OctantWithIndex(batch, index))
	)
	{
	}
}