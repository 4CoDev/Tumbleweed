using Tumbleweed._Boolean;
using Tumbleweed._Byte.FromSystem;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromDouble;

public sealed class BytesOfDouble : EnumerableEnvelope<IEnumerable<IBoolean>>
{
	public BytesOfDouble(IScalar<Double> @double) : base
	(
		new BytesFromSystem(
			new EnumerableOfFunction<Byte>(
				() => BitConverter.GetBytes(@double.Value)))
	)
	{
	}
}