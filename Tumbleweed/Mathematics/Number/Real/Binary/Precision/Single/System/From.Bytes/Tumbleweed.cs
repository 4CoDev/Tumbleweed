using Tumbleweed.Enumerable.With.Length.Statement;
using Tumbleweed.Information.Measurement.Byte.System.From.Boolean.Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Bytes;

public sealed class Tumbleweed : Envelope<System::Single>
{
	public Tumbleweed(IEnumerable<IEnumerable<Boolean.Any>> bytes) : base
	(
		new System(
			new System<System::Byte>(
				new Chunked(bytes),
				4))
	)
	{
	}
}