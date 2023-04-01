using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.FromEnumerable.FromSystem;

public sealed class FractionalWithIndex : FractionalEnvelope
{
	public FractionalWithIndex
	(
		IEnumerable<IFractional> decimals,
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
		IEnumerable<IFractional> decimals,
		IScalar<Int32> index
	) : base
	(
		new FromCollection.FromSystem.FractionalWithIndex(
			new List<IFractional>(decimals),
			index)
	)
	{
	}

}