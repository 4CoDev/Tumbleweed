using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromSingles;

public sealed class BitsOfSingle : EnumerableEnvelope<IBoolean>
{
	public BitsOfSingle(IScalar<Single> @float) : base
	(
		new BitsOfBytes(
			new BytesOfSingle(@float))
	)
	{
	}
}