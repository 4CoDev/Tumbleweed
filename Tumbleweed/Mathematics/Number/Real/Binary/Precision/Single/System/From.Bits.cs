using Tumbleweed.Byte;
using Tumbleweed.Scalar.Immutable;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Boolean = Tumbleweed.Boolean;
using Single = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From;

public sealed class Bits : Envelope<System::Single>
{
	public Bits(IEnumerable<Boolean.Any> bits) : base
	(
		new Mathematics.Number.Real.Binary.Precision.Single.System.From.Bytes.Tumbleweed(
			new BytesFromBits(bits))
	)
	{
	}
}