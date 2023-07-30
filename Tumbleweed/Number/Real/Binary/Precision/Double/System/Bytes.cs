using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Byte = Tumbleweed.Byte;

namespace Tumbleweed.Number.Real.Binary.Precision.Double.System;

public sealed class Bytes : Enumerable.Envelope<IEnumerable<Boolean::Any>>
{
	public Bytes(System::Double @double) : this
	(
		new Value<System::Double>(@double)
	)
	{
	}
	
	public Bytes(Any<System::Double> @double) : base
	(
		new Byte::FromSystem.BytesFromSystem(
			new Result<System::Byte>(
				() => BitConverter.GetBytes(@double.Value)))
	)
	{
	}
}