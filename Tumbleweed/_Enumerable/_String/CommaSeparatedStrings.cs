using Tumbleweed._String;

namespace Tumbleweed._Enumerable._String;

public sealed class CommaSeparatedStrings : StringEnvelope
{
	public CommaSeparatedStrings(IEnumerable<IString> strings) : base
	(
		new _Collection._String.CommaSeparatedStrings(
			new List<IString>(strings))
	)
	{
	}
}