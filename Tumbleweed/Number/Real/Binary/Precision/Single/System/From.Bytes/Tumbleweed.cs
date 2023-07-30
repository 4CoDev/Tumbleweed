using Tumbleweed.Byte.ToSystem;
using Tumbleweed.Enumerable.With.Length.Statement;
using Tumbleweed.Scalar.Immutable;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Boolean = Tumbleweed.Boolean;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Bytes;

public sealed class Tumbleweed : Envelope<System::Single>
{
	public Tumbleweed(IEnumerable<IEnumerable<Boolean.Any>> bytes) : base
	(
		new System(
			new System<System::Byte>(
				new BytesFromChunkedBits(bytes),
				4))
	)
	{
	}
}