using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Strings;

public sealed class CommaSeparatedStrings : ScalarEnvelope<String>
{
	public CommaSeparatedStrings(IEnumerable<String> strings) : base
	(
		new Collections.Strings.CommaSeparatedStrings(
			new List<String>(strings))
	)
	{
	}
}