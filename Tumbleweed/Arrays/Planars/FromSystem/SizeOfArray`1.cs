using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Numerics.Integers.Signed.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Planars.FromSystem;

public sealed class SizeOfArray<T> : EnumerableEnvelope<ISignedInteger>
{
	public SizeOfArray(IScalar<T[,]> array) : base
	(
		new SignedsFromInts32(
			new OfSystem.SizeOfArray<T>(array))
	)
	{
	}
}