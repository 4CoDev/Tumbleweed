using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed._Boolean;

public sealed class BooleanOfFunction : BooleanEnvelope
{
	public BooleanOfFunction(Func<IBoolean> function) : this
	(
		new FunctionFromSystem<IBoolean>(function)
	)
	{
	}
	
	public BooleanOfFunction(IFunction<IBoolean> function) : base
	(
		new BooleanOfScalar(
			new ResultOfFunction<IBoolean>(function))
	)
	{
	}
}