using TumbleSystem.Numerics.Integers.FromSystem;
using TumbleSystem.Numerics.Integers.ToSystem;
using TumbleSystem.Numerics.Integers.ToSystem.Ints32;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Integers.Arithmetic;

public sealed class Logarithm : IntegerEnvelope
{
	public Logarithm(IInteger @base, IInteger argument) : base
	(
		new IntegerFromInt32(
			new ScalarOfDelegate<int>(
				() => (int)Math.Log(
					new NumberFromInteger(@base).Value(),
					new NumberFromInteger(argument).Value())))
	)
	{
	}
}