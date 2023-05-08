using DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;
using DotGod.Nodes.BatchMaps.Spatial.Spaces;
using Tumbleweed.Booleans;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

public sealed class IsSpaceInsideBatch : BooleanEnvelope
{
	public IsSpaceInsideBatch
	(
		ISpacedBatch batch,
		ISpace space
	) : base
	(
		new IsSpaceInsideSpace(
			space,
			new SpaceOfBatch(batch))
	)
	{
	}
}