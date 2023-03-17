using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits;

public sealed class BitOfFunction : BitEnvelope
{
	public BitOfFunction(Func<IBit> function) : this
	(
		new NullaryFromSystem<IBit>(function)
	)
	{
	}
	
	public BitOfFunction(INullaryFunction<IBit> function) : base
	(
		new BitOfScalar(
			new ValueOfFunction<IBit>(function))
	)
	{
	}
}