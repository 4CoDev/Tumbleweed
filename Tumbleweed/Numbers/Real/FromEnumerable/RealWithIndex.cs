using Tumbleweed.Numbers.Integers.Signed;

namespace Tumbleweed.Numbers.Real.FromEnumerable;

public sealed class RealWithIndex : RealEnvelope
{
	public RealWithIndex
	(
		IEnumerable<IReal> decimals,
		ISigned index
	) : base
	(
		new FromCollection.RealWithIndex(
			new List<IReal>(decimals),
			index)
	)
	{
	}
}