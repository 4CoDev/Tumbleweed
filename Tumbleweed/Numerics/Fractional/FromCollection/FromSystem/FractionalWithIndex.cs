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
		new ScalarValue<Int32>(index)
	)
	{
	}
	
	public FractionalWithIndex
	(
		ICollection<IFractional> decimals,
		IScalar<Int32> index
	) : base
	(
		new FractionalOfFunction(
			() => decimals.ElementAt(index.Value))
	)
	{
	}
}