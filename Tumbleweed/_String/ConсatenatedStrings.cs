using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed._String;

public sealed class ConсatenatedStrings : StringEnvelope
{
	public ConсatenatedStrings(params String[] strings) : this
	(
		new StringsFromSystem(strings)
	)
	{
	}
	
	public ConсatenatedStrings(params IString[] strings) : this
	(
		new EnumerableWithElements<IString>(strings)
	)
	{
	}
	
	public ConсatenatedStrings(IEnumerable<IString> strings) : base
	(
		new StringFromSystem(
			new ResultOfFunction<String>(
				() => String.Concat(strings)))
	)
	{
	}
}