using Tumbleweed.Enumerable.Function;
using Tumbleweed.Information.Measurement.Byte.From.System;
using Tumbleweed.Property.Output;
using Enumerable = Tumbleweed.Enumerable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Byte;

public sealed class Enumerable :
	Enumerable::Envelope<IEnumerable<Boolean.Any>>
{
	public Enumerable(Any<System::Single> single) : base
	(
		new Multiple(
			new Result<System::Byte>(
				() => BitConverter.GetBytes(single.Value)))
	)
	{
	}
}