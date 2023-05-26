using Tumbleweed._String;
using Tumbleweed.Scalar;

namespace Tumbleweed._Collection._String;

public sealed class CommaSeparatedStrings : StringEnvelope
{
	public CommaSeparatedStrings(ICollection<IString> strings) : base
	(
		new StringFromSystem(
			new ResultOfFunction<String>(
				() => String.Join(", ", strings)))
	)
	{
	}
}