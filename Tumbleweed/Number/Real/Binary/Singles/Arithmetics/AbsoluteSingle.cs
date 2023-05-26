using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.Singles.Arithmetics;

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