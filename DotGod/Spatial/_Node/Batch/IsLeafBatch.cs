using Tumbleweed._Boolean;

namespace DotGod.Spatial._Node.Batch;

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