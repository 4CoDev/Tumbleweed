using Tumbleweed.Byte.FromSystem;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System;

public sealed class Bytes : Enumerable.Envelope<IEnumerable<Boolean.Any>>
{
	public Bytes(Any<System::Single> single) : base
	(
		new BytesFromSystem(
			new Result<System::Byte>(
				() => BitConverter.GetBytes(single.Value)))
	)
	{
	}
}