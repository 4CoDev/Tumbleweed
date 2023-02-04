using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Binary.OfSystem.Singles.Arithmetics;
using Tumbleweed.Numerics.Binary.ToSystem.Singles;
using Tumbleweed.Numerics.Decimals.FromSystem;

namespace Tumbleweed.Numerics.Decimals.Arithmetics;

public sealed class ProductOfDecimals : DecimalEnvelope
{
	public ProductOfDecimals(params IDecimal[] decimals) : this
	(
		new EnumerableWithElements<IDecimal>(decimals)
	)
	{
	}
	
	public ProductOfDecimals(IEnumerable<IDecimal> decimals) : base
	(
		new DecimalFromSingle(
			new DifferenceOfSingles(
				new SinglesFromDecimals(decimals)))
	)
	{
	}
}