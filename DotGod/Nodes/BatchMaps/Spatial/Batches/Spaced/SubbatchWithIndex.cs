using DotGod.Nodes.BatchMaps.Spatial.Spaces.Octants;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;

using Tumbleweed.Numbers.Spatial;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;
using UnspacedSubbatchWithIndex = Batches.SubbatchWithIndex;

public sealed class SubbatchWithIndex : BatchEnvelope
{
	public SubbatchWithIndex
	(
		ISpacedBatch batch,
		ISpatial<INaturalNumber> index
	) : base
	(
		new BatchWithSpace(
			new UnspacedSubbatchWithIndex(batch, index),
			 new OctantWithIndex(batch, index))
	)
	{
	}
}