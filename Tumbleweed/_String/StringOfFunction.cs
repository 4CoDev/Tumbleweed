using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed._String;

public sealed class StringOfFunction : StringEnvelope
{
	public StringOfFunction(Func<IString> function) : this
	(
		new FunctionFromSystem<IString>(function)
	)
	{
	}
	
	public StringOfFunction(IFunction<IString> function) : base
	(
		new StringOfScalar(
			new ResultOfFunction<IString>(function))
	)
	{
	}
}