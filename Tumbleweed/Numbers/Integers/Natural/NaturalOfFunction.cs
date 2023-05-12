using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

namespace Tumbleweed.Numbers.Integers.Natural;

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