using Tumbleweed.Enumerable.Function;
using Tumbleweed.Information.Measurement.Byte.From.System;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System;

public sealed class Bytes : Enumerable.Envelope<IEnumerable<Boolean.Any>>
{
	public Bytes(System::Double @double) : this
	(
		new One<System::Double>(@double)
	)
	{
	}
	
	public Bytes(Any<System::Double> @double) : base
	(
		new Multiple(
			new Result<System::Byte>(
				() => BitConverter.GetBytes(@double.Value)))
	)
	{
	}
}