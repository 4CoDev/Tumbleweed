using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromDoubles;

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