using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Nullary.Function;

namespace Tumbleweed.Number.Integer.Natural;

public sealed class NaturalOfFunction : NaturalEnvelope
{
	public NaturalOfFunction
	(
		Func<INatural> function
	) : this
	(
		new FunctionFromSystem<INatural>(function)
	)
	{
	}
	
	public NaturalOfFunction
	(
		IFunction<INatural> function
	) : base
	(
		new NaturalOfScalar(
			new ResultOfFunction<INatural>(function))
	)
	{
	}
}