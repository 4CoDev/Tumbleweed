using Tumbleweed.Bits;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem.FromDoubles;

public sealed class MantissaOfDouble : SignedEnvelope
{
	public MantissaOfDouble(IScalar<double> @double) : base
	(
		new SignedWithValues(
			new IsPositiveMantissa(@double),
			new ElementsFromLeft<IBit>(
				new BitsOfDouble(@double),
				new MantissaSize()))
	)
	{
	}
}