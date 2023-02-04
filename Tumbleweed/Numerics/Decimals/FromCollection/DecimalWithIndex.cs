using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.ToSystem.Ints32;

namespace Tumbleweed.Numerics.Decimals.FromCollection;

public sealed class DecimalWithIndex : DecimalEnvelope
{
	public DecimalWithIndex
	(
		ICollection<IDecimal> decimals,
		IInteger index
	) : base
	(
		new FromSystem.DecimalWithIndex(
			decimals,
			new Int32FromInteger(index))
	)
	{
	}
}