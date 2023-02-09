using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers;

public sealed class IntegerOfDelegate : IntegerEnvelope
{
	public IntegerOfDelegate(Func<IInteger> @delegate) : base
	(
		new IntegerOfScalar(
			new ScalarOfDelegate<IInteger>(@delegate))
	)
	{
	}
}