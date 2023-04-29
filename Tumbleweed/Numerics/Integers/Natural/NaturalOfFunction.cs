using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Natural;

public sealed class NaturalOfFunction : NaturalEnvelope
{
	public NaturalOfFunction
	(
		Func<INaturalInteger> function
	) : this
	(
		new FunctionFromSystem<INaturalInteger>(function)
	)
	{
	}
	
	public NaturalOfFunction
	(
		INullaryFunction<INaturalInteger> function
	) : base
	(
		new NaturalOfScalar(
			new ValueOfFunction<INaturalInteger>(function))
	)
	{
	}
}