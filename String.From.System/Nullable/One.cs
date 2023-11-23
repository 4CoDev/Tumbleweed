using Property = Tumbleweed.Property;
using String = Tumbleweed.String;
using System = System;

namespace Tumbleweed.String.From.System.Option;

public sealed class One : Property::Option.Envelope<String::Any>
{
	public One(System::String? option) : this
	(
		new Property::Option.From.System.One
			<System::String>
			(option)
	)
	{
	}
	
	public One
	(
		Property::Output.Any<System::String?> option
	) : this
	(
		 new Property::Option.From.System.One
			 <System::String>
			 (option)
	)
	{
	}
	
	public One
	(
		Property::Option.Any<System::String> nullables
	) : base
	(
		new Property::Option.With.Member.Definition.One<String::Any>(
			new NonNullable.One(nullables),
			new Tumbleweed.Property.Option.Has.Value(nullables))
	)
	{
	}
}