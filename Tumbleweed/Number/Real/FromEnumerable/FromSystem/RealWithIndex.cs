using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.FromEnumerable.FromSystem;

public sealed class RealWithIndex : RealEnvelope
{
	public RealWithIndex
	(
		IEnumerable<IReal> decimals,
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
		IEnumerable<IReal> decimals,
		IScalar<Int32> index
	) : base
	(
		new FromCollection.FromSystem.RealWithIndex(
			new List<IReal>(decimals),
			index)
	)
	{
	}

}