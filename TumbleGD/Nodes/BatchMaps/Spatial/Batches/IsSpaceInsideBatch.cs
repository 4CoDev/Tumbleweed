using TumbleGD.Nodes.BatchMaps.Spatial.Batches.Measurement;
using TumbleGD.Nodes.BatchMaps.Spatial.Occupation;
using Tumbleweed.Booleans;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Batches;

public sealed class IsSpaceInsideBatch : BooleanEnvelope
{
	public IsSpaceInsideBatch
	(
		IMeasuredBatch batch,
		IOccupiedSpace space
	) : base
	(
		new IsSpaceInsideSpace(
			space,
			new SpaceOfMeasuredBatch(batch))
	)
	{
	}
}