using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class StringWithStrings : ScalarEnvelope<string>
{
	public StringWithStrings(params string[] strings) : this
	(
		new EnumerableWithElements<string>(strings)
	)
	{
	}
	
	public StringWithStrings(params IScalar<string>[] strings) : this
	(
		new EnumerableWithElements<IScalar<string>>(strings)
	)
	{
	}

	public StringWithStrings(IEnumerable<IScalar<string>> strings) : this
	(
		new ValuesOfScalars<string>(strings)
	)
	{
	}
	
	public StringWithStrings(IEnumerable<string> strings) : base
	(
		new ScalarOfDelegate<string>(
			() => string.Concat(strings))
	)
	{
	}
}