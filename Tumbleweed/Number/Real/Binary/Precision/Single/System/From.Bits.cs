using Tumbleweed.Byte;
using Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Bytes;
using Tumbleweed.Scalar.Immutable;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Boolean = Tumbleweed.Boolean;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.From;

public sealed class Bits : Envelope<System::Single>
{
	public Bits(IEnumerable<Boolean.Any> bits) : base
	(
		new Bytes.Tumbleweed(
			new BytesFromBits(bits))
	)
	{
	}
}