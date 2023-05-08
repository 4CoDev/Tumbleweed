using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

public sealed class BatchOfFunction : BatchEnvelope
{
	public BatchOfFunction
	(
		Func<IBatch> function
	) : this
	(
		new FunctionFromSystem<IBatch>(function)
	)
	{
	}
	
	public BatchOfFunction
	(
		IFunction<IBatch> function
	) : base
	(
		new BatchOfScalar(
			new ResultOfFunction<IBatch>(function))
	)
	{
	}
}