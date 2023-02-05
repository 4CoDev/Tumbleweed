using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Binaries.OfSystem.Singles.Arithmetics;
using Tumbleweed.Numerics.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Decimals.FromSystem;

namespace Tumbleweed.Numerics.Decimals.Arithmetics;

public sealed class DifferenceOfDecimals : DecimalEnvelope
{
	public DifferenceOfDecimals(params IDecimal[] decimals) : this
	(
		new EnumerableWithElements<IDecimal>(decimals)
	)
	{
	}
	
	public DifferenceOfDecimals(IEnumerable<IDecimal> decimals) : base
	(
		new DecimalFromSingle(
			new DifferenceOfSingles(
				new SinglesFromDecimals(decimals)))
	)
	{
	}
}