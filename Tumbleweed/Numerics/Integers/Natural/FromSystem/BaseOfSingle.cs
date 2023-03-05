using Tumbleweed.Bits;
using Tumbleweed.Enumerables;

namespace Tumbleweed.Numerics.Integers.Natural.FromSystem;

public sealed class BaseOfSingle : NaturalEnvelope
{
	public BaseOfSingle() : base
	(
		new NaturalFromInt32(2)
	)
	{
	}
}