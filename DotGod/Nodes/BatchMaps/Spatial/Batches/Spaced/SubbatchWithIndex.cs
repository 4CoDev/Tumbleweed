using DotGod.Nodes.BatchMaps.Spatial.Spaces.Octants;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;

using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;
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