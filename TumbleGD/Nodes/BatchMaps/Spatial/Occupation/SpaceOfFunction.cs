using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Occupation;

public sealed class SpaceOfFunction : SpaceEnvelope
{
	public SpaceOfFunction
	(
		Func<IOccupiedSpace> function
	) : this
	(
		new FunctionFromSystem<IOccupiedSpace>(function)
	)
	{
	}
	
	public SpaceOfFunction
	(
		INullaryFunction<IOccupiedSpace> function
	) : base
	(
		new SpaceOfScalar(
			new ValueOfFunction<IOccupiedSpace>(
				function))
	)
	{
	}
}