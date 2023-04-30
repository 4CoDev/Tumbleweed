using Tumbleweed.Enumerables;

namespace Tumbleweed.Numbers.Real.Arithmetics;

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