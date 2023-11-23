using Option = Tumbleweed.Property.Option;
using System = System;
using Boolean = Tumbleweed.Mathematics.Boolean;

namespace Tumbleweed.Property.Option.Has.Value;

public sealed class Actual : Boolean::Envelope
{
	public Actual
	(
		Option::Any<System::Object> option
	) : base
	(
		new Boolean::Function.Result.Actual(
			() => option.HasValue)
	)
	{
	}
}