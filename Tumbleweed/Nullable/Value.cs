using System = System;

namespace Tumbleweed.Nullable;

public sealed class Value : Scalar.Envelope<System::Object>
{
	public Value(Tumbleweed.Nullable.Any<System::Object> any) : base
	(
		new Value<System::Object>(any)
	)
	{
	}
}