using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

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
		INullaryFunction<INatural> function
	) : base
	(
		new NaturalOfScalar(
			new ValueOfFunction<INatural>(function))
	)
	{
	}
}