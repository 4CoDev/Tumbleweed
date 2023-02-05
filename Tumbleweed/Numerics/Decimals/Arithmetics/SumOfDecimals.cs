using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Binaries.OfSystem.Singles.Arithmetics;
using Tumbleweed.Numerics.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Decimals.FromSystem;

namespace Tumbleweed.Numerics.Decimals.Arithmetics;

public sealed class SumOfDecimals : DecimalEnvelope
{
	public SumOfDecimals(params IDecimal[] decimals) : this
	(
		new EnumerableWithElements<IDecimal>(decimals)
	)
	{
	}
	
	public SumOfDecimals(IEnumerable<IDecimal> decimals) : base
	(
		new DecimalFromSingle(
			new SumOfSingles(
				new SinglesFromDecimals(decimals)))
	)
	{
	}
}