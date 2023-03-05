using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromEnumerable;

public sealed class CommaSeparatedStrings : ScalarEnvelope<String>
{
	public CommaSeparatedStrings(IEnumerable<String> strings) : base
	(
		new FromCollection.CommaSeparatedStrings(
			new List<String>(strings))
	)
	{
	}
}