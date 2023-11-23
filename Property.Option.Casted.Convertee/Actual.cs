using Option = Tumbleweed.Property.Option;
using System = System;
using Object = Tumbleweed.Object;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Option.As;

public sealed class Actual<T> : Option::Envelope<T>
{
	public Actual(Option::Any<System::Object> origin) : base
	(
		new Option::With.Member.Definition.One<T>(
			new Object::Casted.Convertee.Object<T>(origin),
			new Option::Has.Value.Actual(origin))
	)
	{
	}
}