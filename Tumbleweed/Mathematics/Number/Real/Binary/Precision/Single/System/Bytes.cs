using Tumbleweed.Byte.From.System;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;

public sealed class Bytes : Enumerable.Envelope<IEnumerable<Boolean.Any>>
{
	public Bytes(Any<System::Single> single) : base
	(
		new Multiple(
			new Result<System::Byte>(
				() => BitConverter.GetBytes(single.Value)))
	)
	{
	}
}