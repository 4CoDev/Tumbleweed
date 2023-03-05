using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromCollection.FromSystem;

public sealed class FractionalWithIndex : FractionalEnvelope
{
	public FractionalWithIndex
	(
		ICollection<IFractional> decimals,
		Int32 index
	) : this
	(
		decimals,
		new ScalarOfValue<Int32>(index)
	)
	{
	}
	
	public FractionalWithIndex
	(
		ICollection<IFractional> decimals,
		IScalar<Int32> index
	) : base
	(
		new FractionalOfDelegate(
			() => decimals.ElementAt(index.Value))
	)
	{
	}
}