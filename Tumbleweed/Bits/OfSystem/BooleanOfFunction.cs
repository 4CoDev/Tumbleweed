using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.OfSystem;

public sealed class BooleanOfFunction : ScalarEnvelope<Boolean>
{
	public BooleanOfFunction(Func<Boolean> function) : this
	(
		new NullaryFromSystem<Boolean>(function)
	)
	{
	}
	
	public BooleanOfFunction(INullaryFunction<Boolean> function) : base
	(
		new ValueOfFunction<Boolean>(function)
	)
	{
	}
}