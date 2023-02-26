using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Decimals;

public sealed class DecimalOfDelegate : DecimalEnvelope
{
	public DecimalOfDelegate(Func<IDecimal> @delegate) : base
	(
		new DecimalOfScalar(
			new ValueOfDelegate<IDecimal>(@delegate))
	)
	{
	}
}