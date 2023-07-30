using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary;
using Tumbleweed.Subroutine.Function.Nullary.From;

namespace DotGod.Spatial._Node.Batch.Space;

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