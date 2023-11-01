using Property = Tumbleweed.Property.Output;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Output.Of;

public sealed class New<T> : Property::Envelope<T> where T : new()
{
	public New() : base
	(
		new Property::With.Value<T>(new T())
	)
	{
	}
}