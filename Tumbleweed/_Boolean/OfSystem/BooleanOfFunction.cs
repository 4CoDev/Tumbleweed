using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Nullary.Function;

namespace Tumbleweed._Boolean.OfSystem;

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