using Tumbleweed._Boolean;

namespace DotGod._Node.BatchMap.Spatial.Batches;

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