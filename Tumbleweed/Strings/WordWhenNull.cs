using Tumbleweed.Scalars;

namespace Tumbleweed.Strings;

public sealed class WordWhenNull : ScalarEnvelope<string>
{
	public WordWhenNull(string? origin, string word) : this
	(
		new ScalarOfValue<string?>(origin),
		new ScalarOfValue<string>(word)
	)
	{
	}
	
	public WordWhenNull(IScalar<string?> origin, string word) : this
	(
		origin,
		new ScalarOfValue<string>(word)
	)
	{
	}
	
	public WordWhenNull(string? origin, IScalar<string> word) : this
	(
		new ScalarOfValue<string?>(origin),
		word
	)
	{
	}
	
	public WordWhenNull
	(
		IScalar<string?> origin,
		IScalar<string> word
	) : base
	(
		new ValueOfDelegate<string>(
			() => origin.Value ?? word.Value)
	)
	{
	}
}