using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromEnumerable.FromSystem;

public sealed class FractionalWithIndex : FractionalEnvelope
{
	public FractionalWithIndex
	(
		IEnumerable<IFractional> decimals,
		int index
	) : this
	(
		decimals,
		new ScalarOfValue<int>(index)
	)
	{
	}
	
	public FractionalWithIndex
	(
		IEnumerable<IFractional> decimals,
		IScalar<int> index
	) : base
	(
		new FromCollection.FromSystem.FractionalWithIndex(
			new List<IFractional>(decimals),
			index)
	)
	{
	}

}