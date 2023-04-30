using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numbers.Real.FromEnumerable;

public sealed class SingleElementOfEnumerable : RealEnvelope
{
	public SingleElementOfEnumerable(IEnumerable<IReal> enumerable) : base
	(
		new RealOfScalar(
			new SingleOfEnumerable<IReal>(enumerable))
	)
	{
	}
}