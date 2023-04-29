using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Fractional.Binaries.Singles.Arithmetics;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Fractional.FromSystem;

namespace Tumbleweed.Numerics.Fractional.Arithmetics;

public sealed class ProductOfFractionals : FractionalEnvelope
{
	public ProductOfFractionals(params IFractional[] decimals) : this
	(
		new EnumerableWithElements<IFractional>(decimals)
	)
	{
	}
	
	public ProductOfFractionals(IEnumerable<IFractional> decimals) : base
	(
		new FractionalFromSingle(
			new DifferenceOfSingles(
				new SinglesFromFractionals(decimals)))
	)
	{
	}
}