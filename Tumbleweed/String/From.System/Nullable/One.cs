using Property = Tumbleweed.Property;
using String = Tumbleweed.String;
using System = System;

namespace Tumbleweed.String.From.System.Nullable;

public sealed class One : Property::Nullable.Envelope<String::Any>
{
	public One(System::String? nullable) : this
	(
		new Property::Nullable.From.System.One
			<System::String>
			(nullable)
	)
	{
	}
	
	public One
	(
		Property::Output.Any<System::String?> nullable
	) : this
	(
		 new Property::Nullable.From.System.One
			 <System::String>
			 (nullable)
	)
	{
	}
	
	public One
	(
		Property::Nullable.Any<System::String> nullables
	) : base
	(
		new Property::Nullable.With.Members<String::Any>(
			new NonNullable.One(nullables),
			new Tumbleweed.Property.Nullable.Has.Value(nullables))
	)
	{
	}
}