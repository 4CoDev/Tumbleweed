using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Nullary.Function;

namespace DotGod.Spatial._Node.Batch;

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