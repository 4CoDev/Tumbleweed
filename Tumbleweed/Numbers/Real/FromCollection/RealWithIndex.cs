using Tumbleweed.Numbers.Integers.Signed;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;

namespace Tumbleweed.Numbers.Real.FromCollection;

public sealed class RealWithIndex : RealEnvelope
{
	public RealWithIndex
	(
		ICollection<IReal> decimals,
		ISigned index
	) : base
	(
		new FromSystem.RealWithIndex(
			decimals,
			new Int32FromSigned(index))
	)
	{
	}
}