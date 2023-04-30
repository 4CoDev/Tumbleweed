using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromInts32;

public sealed class NaturalOfInt32 : EnumerableEnvelope<IBoolean>
{
	public NaturalOfInt32(Int32 integer) : this
	(
		new ScalarValue<Int32>(integer)
	)
	{
	}
	
	public NaturalOfInt32(IScalar<Int32> integer) : base
	(
		new WithoutLastElement<IBoolean>(
			new BitsOfInt32(integer))
	)
	{
	}
}