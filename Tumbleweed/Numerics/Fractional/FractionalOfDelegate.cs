using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional;

public sealed class FractionalOfDelegate : FractionalEnvelope
{
	public FractionalOfDelegate(Func<IFractional> @delegate) : base
	(
		new FractionalOfScalar(
			new ValueOfDelegate<IFractional>(@delegate))
	)
	{
	}
}