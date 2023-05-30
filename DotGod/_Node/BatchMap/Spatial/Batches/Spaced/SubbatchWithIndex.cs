using DotGod._Node.BatchMap.Spatial.Spaces.Octants;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Spatial.Point;

namespace DotGod._Node.BatchMap.Spatial.Batches.Spaced;

using INaturalNumber = INatural;
using UnspacedSubbatchWithIndex = Batches.SubbatchWithIndex;

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