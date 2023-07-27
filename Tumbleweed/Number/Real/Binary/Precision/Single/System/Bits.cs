using Tumbleweed.Boolean;
using Tumbleweed.Enumerable;
using Boolean = Tumbleweed.Boolean;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single.System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System;

public sealed class Bits : Envelope<Boolean.Any>
{
	public Bits(Scalar::Any<System::Single> single) : base
	(
		new BitsOfBytes(
			new Single::Bytes(single))
	)
	{
	}
}