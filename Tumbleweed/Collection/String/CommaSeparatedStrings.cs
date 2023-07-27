using Tumbleweed.String;
using Tumbleweed.String.From.System.NonNullable;
using System = System;

namespace Tumbleweed.Collection.String;

public sealed class CommaSeparatedStrings : Envelope
{
	public CommaSeparatedStrings(ICollection<Any> strings) : base
	(
		new One(
			new Scalar.Function.Result<System::String>(
				() => System::String.Join(", ", strings)))
	)
	{
	}
}