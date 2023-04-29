using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Fractional.Binaries.Singles.Arithmetics;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
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