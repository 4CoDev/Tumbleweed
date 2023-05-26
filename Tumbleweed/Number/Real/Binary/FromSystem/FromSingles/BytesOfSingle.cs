using Tumbleweed._Boolean;
using Tumbleweed._Byte.FromSystem;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromSingles;

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