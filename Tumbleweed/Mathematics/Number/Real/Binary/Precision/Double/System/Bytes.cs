using Tumbleweed.Byte.From.System;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

using System = System;
using Byte = Tumbleweed.Byte;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System;

public sealed class Bytes : Enumerable.Envelope<IEnumerable<Boolean.Any>>
{
	public Bytes(System::Double @double) : this
	(
		new Value<System::Double>(@double)
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