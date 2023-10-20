using Tumbleweed.Enumerable.Requirement.Length;
using Tumbleweed.Information.Measurement.Byte.System.From.Boolean.Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable;
using System = System;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Bytes;

public sealed class Tumbleweed : Envelope<System::Single>
{
	public Tumbleweed(IEnumerable<IEnumerable<Boolean.Any>> bytes) : base
	(
		new System(
			new Enumerable::Requirement.Length.System<System::Byte>(
				new Chunked(bytes),
				4))
	)
	{
	}
}