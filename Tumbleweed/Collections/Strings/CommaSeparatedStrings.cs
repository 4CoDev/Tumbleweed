using Tumbleweed.Scalars;

namespace Tumbleweed.Collections.Strings;

public sealed class CommaSeparatedStrings : ScalarEnvelope<String>
{
	public CommaSeparatedStrings(ICollection<String> strings) : base
	(
		new ResultOfFunction<String>(
			() => String.Join(", ", strings))
	)
	{
	}
}