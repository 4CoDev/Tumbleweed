using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Linears.FromSystem;

public sealed class SizeOfArray<T> : IntegerEnvelope
{
	public SizeOfArray(IScalar<T[]> array) : base
	(
		new IntegerFromInt32(
			new OfSystem.SizeOfArray<T>(array))
	)
	{
	}
}