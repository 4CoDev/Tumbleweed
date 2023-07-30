using Tumbleweed.Boolean;
using Tumbleweed.Scalar.Immutable;
using Boolean = Tumbleweed.Boolean;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single.System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System;

public sealed class Bits : Enumerable.Envelope<Boolean.Any>
{
	public Bits(Any<System::Single> single) : base
	(
		new BitsOfBytes(
			new Single::Bytes(single))
	)
	{
	}
}