using String = Tumbleweed.String;
using SCG = System.Collections.Generic;
using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Enumerable.String;

public sealed class CommaSeparated : String::Envelope
{
	public CommaSeparated
	(
		SCG::IEnumerable<String::Any> strings
	) : base
	(
		new String::From.System.NonNullable.One(
			new Property::Function.Result.Actual<System::String>(
				() => System::String.Join(", ", strings)))
	)
	{
	}
}