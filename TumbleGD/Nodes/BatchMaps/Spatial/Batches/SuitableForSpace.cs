using TumbleGD.Nodes.BatchMaps.Spatial.Batches.Measurement;
using TumbleGD.Nodes.BatchMaps.Spatial.Occupation;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Batches;

public sealed class SuitableForSpace : BatchEnvelope
{
	public SuitableForSpace
	(
		IMeasuredBatch batch,
		IOccupiedSpace space
	) : base
	(
		new BatchOfFunction(
			() => Function(batch, space))
	)
	{
	}

	private static ISpatialBatch Function
	(
		IMeasuredBatch batch,
		IOccupiedSpace space
	)
	{
		if (!new IsSpaceInsideBatch(batch, space).State)
			throw new InvalidOperationException(
				"The space is not inside the butch.");
		if (new IsBatchLeaf(batch).State) return batch;
		return new SuitableOrInitial(batch, space);
	}
}