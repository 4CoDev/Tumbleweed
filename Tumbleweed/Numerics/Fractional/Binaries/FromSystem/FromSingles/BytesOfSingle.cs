using Tumbleweed.Booleans;
using Tumbleweed.Bytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromSingles;

public sealed class BytesOfSingle : EnumerableEnvelope<IEnumerable<IBoolean>>
{
	public BytesOfSingle(IScalar<Single> @float) : base
	(
		new BytesFromSystem(
			new EnumerableOfFunction<Byte>(
				() => BitConverter.GetBytes(@float.Value)))
	)
	{
	}
}