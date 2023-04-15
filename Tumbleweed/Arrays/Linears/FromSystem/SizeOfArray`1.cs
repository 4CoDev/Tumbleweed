using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Natural.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Arrays.Linears.FromSystem;

public sealed class SizeOfArray<T> : NaturalEnvelope
{
	public SizeOfArray(IScalar<T[]> array) : base
	(
		new NaturalFromInt32(
			new OfSystem.SizeOfArray<T>(array))
	)
	{
	}
}