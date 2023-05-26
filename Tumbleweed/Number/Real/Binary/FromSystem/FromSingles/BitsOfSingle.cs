using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromSingles;

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