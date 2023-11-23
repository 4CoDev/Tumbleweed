using Tumbleweed.Mathematics.Boolean.Literal;
using Option = Tumbleweed.Property.Option;
using Property = Tumbleweed.Property.Output;


namespace Tumbleweed.Property.Option.With.Value;

public sealed class One<T> : Option::Envelope<T>
{
	public One(T value) : this
	(
		new Property::With.Value.One<T>(value)
	)
	{
	}
	
	public One(Property::Any<T> value) : base
	(
		new Option::With.Member.Definition.One<T>(
			value,
			new True()))
	{
	}
}