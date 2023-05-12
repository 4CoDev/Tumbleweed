using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

namespace Tumbleweed.Booleans.OfSystem;

public sealed class BooleanOfFunction : ScalarEnvelope<Boolean>
{
	public BooleanOfFunction(Func<Boolean> function) : this
	(
		new FunctionFromSystem<Boolean>(function)
	)
	{
	}
	
	public BooleanOfFunction(IFunction<Boolean> function) : base
	(
		new ResultOfFunction<Boolean>(function)
	)
	{
	}
}