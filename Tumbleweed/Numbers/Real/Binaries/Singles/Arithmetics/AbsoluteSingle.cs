using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.Singles.Arithmetics;

public sealed class AbsoluteSingle : ScalarEnvelope<Single>
{
	public AbsoluteSingle(Single single) : base
	(
		new ScalarValue<Single>(single)
	)
	{
	}
	
	public AbsoluteSingle(IScalar<Single> single) : base
	(
		new ResultOfFunction<Single>(
			() => Math.Abs(single.Value))
	)
	{
	}
}