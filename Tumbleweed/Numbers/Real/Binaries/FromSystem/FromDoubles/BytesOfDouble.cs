using Tumbleweed.Booleans;
using Tumbleweed.Bytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromDoubles;

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