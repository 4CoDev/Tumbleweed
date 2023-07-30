using Tumbleweed.Enumerable.With.Length.Statement;
using Tumbleweed.Scalar.Immutable;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Boolean = Tumbleweed.Boolean;
using Integer = Tumbleweed.Number.Integer.System.Medium;
using Byte = Tumbleweed.Byte;

namespace Tumbleweed.Number.Integer.System.Medium.From.Bytes;

public sealed class Tumbleweed : Envelope<System::Int32>
{
	public Tumbleweed(IEnumerable<IEnumerable<Boolean::Any>> bytes) : base
	(
		new Integer::From.Bytes.System(
			new System<System::Byte>(
				new Byte::ToSystem.BytesFromChunkedBits(bytes),
				4))
	)
	{
	}
}