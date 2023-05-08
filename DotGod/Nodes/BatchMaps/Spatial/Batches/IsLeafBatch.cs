using Tumbleweed.Booleans;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

public sealed class IsLeafBatch : BooleanEnvelope
{
	public IsLeafBatch(IBatch batch) : base
	(
		new BooleanOfFunction(
			() => batch.Subbatches.Existing)
	)
	{
	}
}