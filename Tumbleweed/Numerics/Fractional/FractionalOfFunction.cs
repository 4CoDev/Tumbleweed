using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional;

public sealed class FractionalOfFunction : FractionalEnvelope
{
	public FractionalOfFunction(Func<IFractional> @delegate) : base
	(
		new FractionalOfScalar(
			new ValueOfFunction<IFractional>(@delegate))
	)
	{
	}
}