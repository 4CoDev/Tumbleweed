using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System;

public sealed class Bits : Enumerable.Envelope<Boolean.Any>
{
	public Bits(Any<System::Double> @double) : base
	(
		new BitsOfBytes(
			new Bytes(@double))
	)
	{
	}
}