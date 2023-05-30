using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Nullary.Function;

namespace DotGod._Node.BatchMap.Spatial.Spaces;

public sealed class SpaceOfFunction : SpaceEnvelope
{
	public SpaceOfFunction
	(
		Func<ISpace> function
	) : this
	(
		new FunctionFromSystem<ISpace>(function)
	)
	{
	}
	
	public SpaceOfFunction
	(
		IFunction<ISpace> function
	) : base
	(
		new SpaceOfScalar(
			new ResultOfFunction<ISpace>(
				function))
	)
	{
	}
}