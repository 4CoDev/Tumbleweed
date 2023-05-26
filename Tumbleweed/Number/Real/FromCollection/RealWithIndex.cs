using Tumbleweed.Number.Integer.Signed;
using Tumbleweed.Number.Integer.Signed.ToSystem._Int32;

namespace Tumbleweed.Number.Real.FromCollection;

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