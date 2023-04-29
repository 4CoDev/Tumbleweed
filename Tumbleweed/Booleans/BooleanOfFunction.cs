using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Booleans;

public sealed class BooleanOfFunction : BooleanEnvelope
{
	public BooleanOfFunction(Func<IBoolean> function) : this
	(
		new FunctionFromSystem<IBoolean>(function)
	)
	{
	}
	
	public BooleanOfFunction(INullaryFunction<IBoolean> function) : base
	(
		new BooleanOfScalar(
			new ValueOfFunction<IBoolean>(function))
	)
	{
	}
}