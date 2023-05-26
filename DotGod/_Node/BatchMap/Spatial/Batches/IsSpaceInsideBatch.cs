using DotGod._Node.BatchMap.Spatial.Batches.Spaced;
using DotGod._Node.BatchMap.Spatial.Spaces;
using Tumbleweed._Boolean;

namespace DotGod._Node.BatchMap.Spatial.Batches;

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