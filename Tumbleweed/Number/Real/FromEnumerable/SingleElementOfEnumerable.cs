using Tumbleweed.Scalar.FromEnumerable;

namespace Tumbleweed.Number.Real.FromEnumerable;

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