using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Binaries.OfSystem.Singles.Arithmetics;
using Tumbleweed.Numerics.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Fractional.FromSystem;

namespace Tumbleweed.Numerics.Fractional.Arithmetics;

public sealed class SumOfFractionals : FractionalEnvelope
{
	public SumOfFractionals(params IFractional[] decimals) : this
	(
		new EnumerableWithElements<IFractional>(decimals)
	)
	{
	}
	
	public SumOfFractionals(IEnumerable<IFractional> decimals) : base
	(
		new FractionalFromSingle(
			new SumOfSingles(
				new SinglesFromFractionals(decimals)))
	)
	{
	}
}