using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

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