using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Function.Nullary;

namespace DotGod._Node.BatchMap.Spatial.Batches;

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