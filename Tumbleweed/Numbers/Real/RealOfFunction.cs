using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real;

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