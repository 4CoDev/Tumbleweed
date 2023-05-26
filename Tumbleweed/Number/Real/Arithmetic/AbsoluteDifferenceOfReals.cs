using Tumbleweed._Enumerable;

namespace Tumbleweed.Number.Real.Arithmetic;

public sealed class AbsoluteDifferenceOfReals : RealEnvelope
{
	public AbsoluteDifferenceOfReals
	(
		params IReal[] reals
	) : this
	(
		new EnumerableWithElements<IReal>(reals)
	)
	{
	}
	
	public AbsoluteDifferenceOfReals
	(
		IEnumerable<IReal> reals) : base
	(
		new AbsoluteReal(
			new DifferenceOfReals(reals))
	)
	{
	}
}