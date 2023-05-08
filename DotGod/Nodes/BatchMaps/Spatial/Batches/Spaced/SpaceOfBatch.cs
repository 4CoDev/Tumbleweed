using DotGod.Nodes.BatchMaps.Spatial.Spaces;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;

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