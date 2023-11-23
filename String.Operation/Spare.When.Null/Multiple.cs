using Enumerable = Tumbleweed.Enumerable;
using String = Tumbleweed.String;
using System = System;
using Option = Tumbleweed.Property.Option;

namespace Tumbleweed.String.Operation.Spare.When.Null;

public sealed class Multiple : Enumerable::Envelope<String::Any>
{
	public Multiple
	(
		IEnumerable<System::String?> nullables,
		System::String spare
	) : this
	(
		new From.System.Option.Multiple(nullables),
		new From.System.NonNullable.One(spare)
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<String::Any?> nullables,
		String::Any spare
	) : this
	(
		new Option::From.System.Multiple<String::Any>(nullables),
		spare
	)
	{
	}
	
	public Multiple
	(
		IEnumerable<Option::Any<String::Any>> nullables,
		String::Any spare
	) : base
	(
		new Enumerable::Selected
			<Option::Any<String::Any>, String::Any>(
			nullables,
			option => Expression(option, spare))
	)
	{
	}

	private static Any Expression
	(
		Option::Any<String::Any> option,
		String::Any spare
	) =>
	(
		new One(option, spare)
	);
}