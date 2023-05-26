using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real;

public sealed class RealOfFunction : RealEnvelope
{
	public RealOfFunction(Func<IReal> @delegate) : base
	(
		new RealOfScalar(
			new ResultOfFunction<IReal>(@delegate))
	)
	{
	}
}