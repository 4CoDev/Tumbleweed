using Tumbleweed.Number.Integer.Signed;

namespace Tumbleweed.Number.Real.FromEnumerable;

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