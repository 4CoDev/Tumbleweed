using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromCollection.FromSystem;

public sealed class FractionalWithIndex : FractionalEnvelope
{
	public FractionalWithIndex
	(
		ICollection<IFractional> decimals,
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
		ICollection<IFractional> decimals,
		IScalar<int> index
	) : base
	(
		new FractionalOfDelegate(
			() => decimals.ElementAt(index.Value))
	)
	{
	}
}