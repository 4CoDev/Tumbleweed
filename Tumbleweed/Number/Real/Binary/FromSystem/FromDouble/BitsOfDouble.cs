using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromDouble;

public sealed class BitsOfDouble : EnumerableEnvelope<IBoolean>
{
	public BitsOfDouble(IScalar<Double> @double) : base
	(
		new BitsOfBytes(
			new BytesOfDouble(@double))
	)
	{
	}
}