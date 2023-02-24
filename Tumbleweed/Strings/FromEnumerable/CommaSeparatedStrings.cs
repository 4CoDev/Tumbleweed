using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromEnumerable;

public sealed class CommaSeparatedStrings : ScalarEnvelope<string>
{
	public CommaSeparatedStrings(IEnumerable<string> strings) : base
	(
		new FromCollection.CommaSeparatedStrings(
			new List<string>(strings))
	)
	{
	}
}