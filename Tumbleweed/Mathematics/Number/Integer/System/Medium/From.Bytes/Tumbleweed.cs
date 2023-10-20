using Tumbleweed.Enumerable.Requirement.Length;
using Tumbleweed.Information.Measurement.Byte.System.From.Boolean.Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Bytes;

public sealed class Tumbleweed : Envelope<System::Int32>
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