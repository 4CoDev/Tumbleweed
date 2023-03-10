using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Binaries.OfSystem.Singles.Arithmetics;
using Tumbleweed.Numerics.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Fractional.FromSystem;

namespace Tumbleweed.Numerics.Fractional.Arithmetics;

public sealed class DifferenceOfFractionals : FractionalEnvelope
{
	public DifferenceOfFractionals(params IFractional[] decimals) : this
	(
		new EnumerableWithElements<IFractional>(decimals)
	)
	{
	}
	
	public DifferenceOfFractionals(IEnumerable<IFractional> decimals) : base
	(
		new FractionalFromSingle(
			new DifferenceOfSingles(
				new SinglesFromFractionals(decimals)))
	)
	{
	}
}