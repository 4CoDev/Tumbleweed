using Tumbleweed.Boolean;
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;

public sealed class Bits : Enumerable.Envelope<Boolean.Any>
{
	public Bits(Any<System::Single> single) : base
	(
		new BitsOfBytes(
			new Bytes(single))
	)
	{
	}
}