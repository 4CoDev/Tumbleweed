using DotGod._Node.BatchMap.Spatial.Spaces;

namespace DotGod._Node.BatchMap.Spatial.Batches.Spaced;

public sealed class SpaceOfBatch : SpaceEnvelope
{
	public SpaceOfBatch(ISpacedBatch batch) : base
	(
		new SpaceOfFunction(
			() => batch.Space)
	)
	{
	}
}