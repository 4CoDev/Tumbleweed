using String = Tumbleweed.String;
using SCG = System.Collections.Generic;
using Collection = Tumbleweed.Collection;

namespace Tumbleweed.Enumerable.String;

public sealed class CommaSeparated : String::Envelope
{
	public CommaSeparated
	(
		SCG::IEnumerable<String::Any> strings
	) : base
	(
		new Collection::String.CommaSeparatedStrings(
			new SCG::List<String::Any>(strings))
	)
	{
	}
}