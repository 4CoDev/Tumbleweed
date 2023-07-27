using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Byte = Tumbleweed.Byte;

namespace Tumbleweed.Number.Real.Binary.Precision.Double.System;

public sealed class Bytes :
	Envelope<IEnumerable<Boolean::Any>>
{
	public Bytes(System::Double @double) : this
	(
		new Scalar::Of.Value<System::Double>(@double)
	)
	{
	}
	
	public Bytes(Scalar::Any<System::Double> @double) : base
	(
		new Byte::FromSystem.BytesFromSystem(
			new Result<System::Byte>(
				() => BitConverter.GetBytes(@double.Value)))
	)
	{
	}
}