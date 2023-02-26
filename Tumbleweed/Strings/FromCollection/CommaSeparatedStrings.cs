using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromCollection;

public sealed class CommaSeparatedStrings : ScalarEnvelope<string>
{
	public CommaSeparatedStrings(ICollection<string> strings) : base
	(
		new ValueOfDelegate<string>(
			() => string.Join(", ", strings))
	)
	{
	}
}