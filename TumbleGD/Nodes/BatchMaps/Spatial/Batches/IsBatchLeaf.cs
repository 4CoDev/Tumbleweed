using Tumbleweed.Booleans;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Batches;

public sealed class IsBatchLeaf : BooleanEnvelope
{
	public IsBatchLeaf(ISpatialBatch batch) : base
	(
		new BooleanOfFunction(
			() => batch.Subbatches.Existing)
	)
	{
	}
}