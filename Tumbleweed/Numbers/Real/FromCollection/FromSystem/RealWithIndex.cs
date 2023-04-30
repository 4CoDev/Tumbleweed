using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.FromCollection.FromSystem;

public sealed class RealWithIndex : RealEnvelope
{
	public RealWithIndex
	(
		ICollection<IReal> decimals,
		Int32 index
	) : this
	(
		decimals,
		new ScalarValue<Int32>(index)
	)
	{
	}
	
	public RealWithIndex
	(
		ICollection<IReal> decimals,
		IScalar<Int32> index
	) : base
	(
		new RealOfFunction(
			() => decimals.ElementAt(index.Value))
	)
	{
	}
}