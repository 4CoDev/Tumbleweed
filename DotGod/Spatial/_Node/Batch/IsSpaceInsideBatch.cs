using DotGod.Spatial._Node.Batch.Spaces;
using DotGod.Spatial._Node.Spaced.Batch;
using Tumbleweed._Boolean;

namespace DotGod.Spatial._Node.Batch;

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