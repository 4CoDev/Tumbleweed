using Enumerable = Tumbleweed.Enumerable;
using Property = Tumbleweed.Property;
using String = Tumbleweed.String;
using System = System;

namespace Tumbleweed.String.From.System.Option;

public sealed class Multiple : 
	Enumerable::Envelope<
		Property::Option.Any<
			String::Any>>
{
	public Multiple
	(
		IEnumerable<System::String?> nullables
	) : this
	(
		new Property::Option.From.System.Multiple
			<System::String>
			(nullables)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Property::Option.Any<System::String>> nullables
	) : base
	(
		new Enumerable::Selected
		<
			Property::Option.Any<System::String>,
			Property::Option.Any<String::Any>
		>
		(
			nullables,
			option => new String::From.System.Option.One(option)
		)
	)
	{
	}
}