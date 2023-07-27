using System = System;

namespace Tumbleweed.Mutable;

public sealed class Value : Scalar.Envelope<System::Object>
{
	public Value(Any<System::Object> mutable) : base
	(
		new Value<System::Object>(mutable)
	)
	{
	}
}