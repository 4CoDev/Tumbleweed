using Enumerable = Tumbleweed.Enumerable;
using Property = Tumbleweed.Property;
using String = Tumbleweed.String;
using System = System;

namespace Tumbleweed.String.From.System.Nullable;

public sealed class Multiple : 
	Enumerable::Envelope<
		Property::Nullable.Any<
			String::Any>>
{
	public Multiple
	(
		IEnumerable<System::String?> nullables
	) : this
	(
		new Property::Nullable.From.System.Multiple
			<System::String>
			(nullables)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Property::Nullable.Any<System::String>> nullables
	) : base
	(
		new Enumerable::Selected
		<
			Property::Nullable.Any<System::String>,
			Property::Nullable.Any<String::Any>
		>
		(
			nullables,
			nullable => new String::From.System.Nullable.One(nullable)
		)
	)
	{
	}
}