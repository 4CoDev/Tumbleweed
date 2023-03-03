using Tumbleweed.Scalars;

namespace Tumbleweed.Strings.FromObjects;

public sealed class WordWhenNull : ScalarEnvelope<string>
{
	public WordWhenNull(object? origin, string word) : this
	(
		new ScalarOfValue<object?>(origin),
		new ScalarOfValue<string>(word)
	)
	{
	}
	
	public WordWhenNull(IScalar<object?> origin, string word) : this
	(
		origin,
		new ScalarOfValue<string>(word)
	)
	{
	}
	
	public WordWhenNull(object? origin, IScalar<string> word) : this
	(
		new ScalarOfValue<object?>(origin),
		word
	)
	{
	}
	
	public WordWhenNull
	(
		IScalar<object?> origin,
		IScalar<string> word
	) : base
	(
		new ValueOfDelegate<string>(
			() => new NullableFromNullable(origin.Value).Value ?? word.Value)
	)
	{
	}
}