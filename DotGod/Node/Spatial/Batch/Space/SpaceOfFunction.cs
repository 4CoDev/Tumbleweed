using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary.From;

namespace DotGod.Node.Spatial.Batch.Space;

public sealed class SpaceOfFunction : SpaceEnvelope
{
	public SpaceOfFunction
	(
		Func<ISpace> function
	) : this
	(
		new System<ISpace>(function)
	)
	{
	}
	
	public SpaceOfFunction
	(Tumbleweed.Subroutine.Function.Nullary.Any<ISpace> function
	) : base
	(
		new SpaceOfScalar(
			new Actual<ISpace>(
				function))
	)
	{
	}
}