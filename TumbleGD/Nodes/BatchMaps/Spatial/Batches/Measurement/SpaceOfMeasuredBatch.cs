using TumbleGD.Nodes.BatchMaps.Spatial.Occupation;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Batches.Measurement;

public sealed class SpaceOfMeasuredBatch : SpaceEnvelope
{
	public SpaceOfMeasuredBatch(IMeasuredBatch batch) : base
	(
		new SpaceOfFunction(
			() => batch.Space)
	)
	{
	}
}