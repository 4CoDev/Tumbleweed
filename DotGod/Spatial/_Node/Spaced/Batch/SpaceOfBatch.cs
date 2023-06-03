using DotGod.Spatial._Node.Batch.Space;

namespace DotGod.Spatial._Node.Spaced.Batch;

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