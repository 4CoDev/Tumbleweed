using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromCollection;

public sealed class CommaSeparatedStrings : ScalarEnvelope<String>
{
	public CommaSeparatedStrings(ICollection<String> strings) : base
	(
		new ValueOfDelegate<String>(
			() => string.Join(", ", strings))
	)
	{
	}
}