using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Batches;

public sealed class BatchOfFunction : BatchEnvelope
{
	public BatchOfFunction
	(
		Func<ISpatialBatch> function
	) : this
	(
		new FunctionFromSystem<ISpatialBatch>(function)
	)
	{
	}
	
	public BatchOfFunction
	(
		INullaryFunction<ISpatialBatch> function
	) : base
	(
		new BatchOfScalar(
			new ValueOfFunction<ISpatialBatch>(function))
	)
	{
	}
}