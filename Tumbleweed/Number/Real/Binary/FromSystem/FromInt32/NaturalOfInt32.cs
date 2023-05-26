using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromInt32;

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